using System;
using System.Drawing;
using System.Windows.Forms;

using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

using System.IO;
using Microsoft.Win32;

using Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TimeLogger
{
    public partial class MainForm : Form
    {
        // State enum
        public enum State
        {
            ClockedIn,
            ClockedOut,
            OnBreak,
            SendingEmail
        };

        // Members
        private static MiniForm m_miniForm = new MiniForm();
        public static State m_currentState = State.ClockedOut;
        private static DateTime m_startTime;
        private static DateTime m_endTime;
        private static DateTime m_breakStartTime;
        private static DateTime m_breakEndTime;

        // Methods
        // Constructor
        public MainForm()
        {
            InitializeComponent();

            m_miniForm.SetMainFormReference( this );
            m_miniForm.FormClosing += FormClosingHandler;
            FormClosing += FormClosingHandler;
            SetDesktopLocation( Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height );

            // Top most setting
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
            m_miniForm.TopMost = Properties.Settings.Default.AlwaysOnTop;

            // Default output directory
            if( Properties.Settings.Default.OutputDirectory == "%UNINITIALISED%" )
                Properties.Settings.Default.OutputDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Desktop ) + "\\";

            // Store registry key in order to run on Windows startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
            var key = "GGG Time Logger";

            if( rk == null && Properties.Settings.Default.RunOnStartup )
            {
                rk.SetValue( key, Application.ExecutablePath.ToString() );
            }
            else if( rk != null && !Properties.Settings.Default.RunOnStartup )
            {
                rk.DeleteValue( key );
            }

            // Test the excel file
            if( !File.Exists( Properties.Settings.Default.OutputDirectory + Properties.Settings.Default.OutputExcelFile ) )
            {
                var outputText = "Output excel spreadsheet was not found at: \n" +
                    Properties.Settings.Default.OutputDirectory + Properties.Settings.Default.OutputExcelFile +
                    "\n\nWould you like to locate it?";
                if( MessageBox.Show( outputText, "File Not Found", MessageBoxButtons.YesNo ) == DialogResult.Yes )
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.InitialDirectory = Properties.Settings.Default.OutputDirectory;
                    openFileDialog1.Filter = "Excel Files (.xls/.xlsx)|*.xls*";
                    openFileDialog1.FilterIndex = 1;
                    openFileDialog1.Multiselect = false;

                    if( openFileDialog1.ShowDialog() == DialogResult.OK )
                    {
                        var fileNameStart = openFileDialog1.FileName.LastIndexOf( '\\' );
                        Properties.Settings.Default.OutputDirectory = openFileDialog1.FileName.Substring( 0, fileNameStart ) + "\\";
                        Properties.Settings.Default.OutputExcelFile = openFileDialog1.FileName.Substring( fileNameStart + 1 );
                        outputText = "Output excel spreadsheet has been updated: \n" +
                            Properties.Settings.Default.OutputDirectory + Properties.Settings.Default.OutputExcelFile;
                        MessageBox.Show( outputText, "Updated File Location", MessageBoxButtons.OK );
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        // Public methods
        public void ToggleForms()
        {
            m_miniForm.Visible = !m_miniForm.Visible;
            Visible = !Visible;
        }

        public void CreateEmail()
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = ( Outlook._MailItem )oApp.CreateItem( Outlook.OlItemType.olMailItem );
            oMailItem.To = "alex.denford@xtra.co.nz";
            oMailItem.Subject = "Timesheet";
            oMailItem.Body = "Hello, Here is my time sheet for: \n\nThank you!\n\n--\nAlex Denford";
            oMailItem.Display( true );
        }

        // Private methods
        private void FormClosingHandler( object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void MiniView_Button_Click( object sender, EventArgs e )
        {
            ToggleForms();
        }

        public void ToggleClockState()
        {
            if( m_currentState == State.ClockedIn )
                ClockOut();
            else
                ClockIn();
        }

        // Toggle break (from clocked in to break & break to clock in)
        public void ToggleBreakState()
        {
            if( m_currentState == State.ClockedIn )
            {
                m_currentState = State.OnBreak;
                m_breakStartTime = DateTime.Now;
                ClockToggle_Button.Text = "On Break";
            }
            else if( m_currentState == State.OnBreak )
            {
                m_currentState = State.ClockedIn;
                m_breakEndTime = DateTime.Now;
                ClockToggle_Button.Text = "Clock out";
            }
            else MessageBox.Show( "You cannot take a break without clocking in first!", "Take Break", MessageBoxButtons.OK );
        }

        // Handles clocking in
        private void ClockIn()
        {
            m_currentState = State.ClockedIn;
            ClockToggle_Button.Text = "Clock Out";
            m_miniForm.SetButtonText( ClockToggle_Button.Text );
            m_startTime = DateTime.Now;
            Main_Timer.Start();
        }

        // Handles clocking out
        private void ClockOut()
        {
            if( MessageBox.Show( "Are you sure you want to clock out?", "Confirm", MessageBoxButtons.YesNo ) == DialogResult.Yes )
            {
                m_currentState = State.ClockedOut;
                ClockToggle_Button.Text = "Clock In";
                m_miniForm.SetButtonText( ClockToggle_Button.Text );
                m_endTime = DateTime.Now;
                Main_Timer.Stop();
                WorkTimer_Label.Text = BreakTimer_Label.Text = "00:00:00";

                FillOutTimesheet();
            }
        }

        private void FillOutTimesheet()
        {
            var strOutputPath = Properties.Settings.Default.OutputDirectory + Properties.Settings.Default.OutputExcelFile;
            DateTime today = DateTime.Today;
            var work_hours = ( m_endTime.TimeOfDay - m_startTime.TimeOfDay ).TotalHours;
            var break_minutes = ( m_breakEndTime.TimeOfDay - m_breakStartTime.TimeOfDay ).TotalMinutes;

            // Write data to text file
            if( Properties.Settings.Default.ExportToTextFile )
            {
                using( System.IO.StreamWriter file = new System.IO.StreamWriter( Properties.Settings.Default.OutputDirectory + @"\GGGTimeLogger.txt", true ) )
                {
                    file.WriteLine( today.DayOfWeek.ToString() + " " + today.ToString( "MMMM dd" ) +
                                    "\t\t\tStart Time: " + m_startTime.ToString( @"hh\:mm\:ss" ) +
                                    "\t\t\tEnd Time: " + m_endTime.ToString( @"hh\:mm\:ss" ) +
                                    "\t\t\tTotal Break: " + ( int )break_minutes + " minutes" +
                                    "\t\t\tTotal Work: " + work_hours.ToString( "0.00" ) + " hours" );
                }
            }

            // While loop to allow user to retry if file is open by another process
            while( true )
            {
                try
                {
                    // Write data to excel spreadsheet
                    XSSFWorkbook hssfwb;

                    using( FileStream file = new FileStream( strOutputPath, FileMode.Open, FileAccess.Read ) )
                    {
                        hssfwb = new XSSFWorkbook( file );
                        file.Close();
                    }

                    ISheet sheet = hssfwb.GetSheetAt( 0 );
                    sheet.ForceFormulaRecalculation = true;

                    // Calculate if this week is the first or second week of our two week period
                    int iWeekNumber = ( int )( ( today.DayOfYear % 14 ) / 7 );

                    // Calculate current day
                    int iDayOfWeek = ( int )today.DayOfWeek - 1;
                    iDayOfWeek = ( iDayOfWeek == -1 ? 6 : iDayOfWeek );

                    // Set week starting date
                    if( iWeekNumber == 0 && iDayOfWeek == 0 )
                    {
                        sheet.GetRow( 7 ).GetCell( 8 ).SetCellValue( today.Date.ToShortDateString() );
                    }

                    int iRow = 10 + iDayOfWeek + iWeekNumber * 8;

                    // Main Start & End Times
                    sheet.GetRow( iRow ).GetCell( 2 ).SetCellValue( m_startTime.ToString( @"hh\:mm\:ss" ) );
                    sheet.GetRow( iRow ).GetCell( 3 ).SetCellValue( m_endTime.ToString( @"hh\:mm\:ss" ) );

                    // Secondary Start & End Times
                    //sheet.GetRow( iRow ).GetCell( 4 ).SetCellValue( EndTime.ToString( "hh:mm tt" ) ); 
                    //sheet.GetRow( iRow ).GetCell( 5 ).SetCellValue( EndTime.ToString( "hh:mm tt" ) ); 

                    // Unpaid break
                    int iUnpaidBreak = ( int )Math.Max( 0.0, break_minutes - 30.0 );
                    sheet.GetRow( iRow ).GetCell( 7 ).SetCellValue( iUnpaidBreak );

                    //File.Delete( strOutputPath );

                    // Save
                    using( FileStream file = new FileStream( strOutputPath, FileMode.Open, FileAccess.Read ) )
                    {
                        hssfwb.Write( file );
                        file.Close();
                    }

                    // If Friday, email to GGGPayroll
                    if( iWeekNumber == 1 && iDayOfWeek == 4 )
                        if( MessageBox.Show( "Do you want to email your time sheet now?", "Confirm", MessageBoxButtons.YesNo ) == DialogResult.Yes )
                            CreateEmail();

                    break;
                }
                catch( IOException )
                {
                    // Handle IO Exception with elegent message box
                    string strText = "\"" + strOutputPath + "\" is already in use. Please close the file and try again";

                    if( MessageBox.Show( strText, "File IO Error", MessageBoxButtons.RetryCancel ) == DialogResult.Cancel )
                    {
                        break;
                    }
                }
            }
        }

        // Clock in toggle
        private void ClockToggle_Button_Click( object sender, EventArgs e )
        {
            if( m_currentState == State.OnBreak )
                ToggleBreakState();
            else
                ToggleClockState();
        }

        // Visuals for clock button
        private void ClockToggle_Button_MouseEnter( object sender, EventArgs e )
        {
            ClockToggle_Button.ForeColor = Color.DodgerBlue;
        }

        private void ClockToggle_Button_MouseLeave( object sender, EventArgs e )
        {
            ClockToggle_Button.ForeColor = SystemColors.ButtonHighlight;
        }

        // Show settings button
        private void Settings_Button_Click( object sender, EventArgs e )
        {
            var settingsForm = new SettingsForm();

            if( settingsForm.ShowDialog() == DialogResult.OK )
            {
                // Apply settings
                this.TopMost = Properties.Settings.Default.AlwaysOnTop;
                m_miniForm.TopMost = Properties.Settings.Default.AlwaysOnTop;
            }
        }

        // Timer
        private void timer1_Tick( object sender, EventArgs e )
        {
            // Increment main timer
            var current_time = DateTime.Now;
            WorkTimer_Label.Text = ( current_time - m_startTime ).ToString( @"hh\:mm\:ss" );

            // Increment break timer if on break
            if( m_currentState == State.OnBreak )
            {
                BreakTimer_Label.Text = ( current_time - m_breakStartTime ).ToString( @"hh\:mm\:ss" );
                m_miniForm.SetButtonText( BreakTimer_Label.Text );
            }
        }

        // Take break
        private void Break_Button_Click( object sender, EventArgs e )
        {
            ToggleBreakState();
        }

        private void ResetTimesheet_Button_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show( "Are you sure you want to reset your time sheet?", "Confirm", MessageBoxButtons.YesNo ) == DialogResult.No )
                return;

            var strOutputPath = Properties.Settings.Default.OutputDirectory + Properties.Settings.Default.OutputExcelFile;
            var today = DateTime.Today;

            // While loop to allow user to retry if file is open by another process
            while( true )
            {
                try
                {
                    // Write data to excel spreadsheet
                    XSSFWorkbook hssfwb;

                    using( FileStream file = new FileStream( strOutputPath, FileMode.Open, FileAccess.Read ) )
                    {
                        hssfwb = new XSSFWorkbook( file );
                        file.Close();
                    }

                    hssfwb.SetForceFormulaRecalculation( true );
                    ISheet sheet = hssfwb.GetSheetAt( 0 );
                    sheet.ForceFormulaRecalculation = true;

                    // Calculate if this week is the first or second week of our two week period
                    int iWeekNumber = ( int )( ( today.DayOfYear % 14 ) / 7 );
                    int iDayOfWeek = ( int )today.DayOfWeek - 1;
                    iDayOfWeek = ( iDayOfWeek == -1 ? 6 : iDayOfWeek );

                    sheet.GetRow( 7 ).GetCell( 8 ).SetCellType( CellType.String );

                    for( int iRow = 10; iRow <= 24; ++iRow )
                    {
                        if( iRow == 17 )
                            continue;

                        // Main Start & End Times
                        sheet.GetRow( iRow ).GetCell( 2 ).SetCellValue( "" );
                        sheet.GetRow( iRow ).GetCell( 3 ).SetCellValue( "" );

                        // Secondary Start & End Times
                        sheet.GetRow( iRow ).GetCell( 4 ).SetCellValue( "" );
                        sheet.GetRow( iRow ).GetCell( 5 ).SetCellValue( "" );

                        // Unpaid break
                        sheet.GetRow( iRow ).GetCell( 7 ).SetCellValue( "" );
                        sheet.GetRow( iRow ).GetCell( 10 ).SetCellValue( "" );
                        sheet.GetRow( iRow ).GetCell( 11 ).SetCellValue( "" );
                    }

                    File.Delete( strOutputPath );

                    // Save
                    using( FileStream file = new FileStream( strOutputPath, FileMode.CreateNew, FileAccess.Write ) )
                    {
                        hssfwb.Write( file );
                        file.Close();
                    }

                    break;
                }
                catch( IOException )
                {
                    // Handle IO Exception with elegent message box
                    string strText = "\"" + strOutputPath + "\" is already in use. Please close the file and try again";

                    if( MessageBox.Show( strText, "File IO Error", MessageBoxButtons.RetryCancel ) == DialogResult.Cancel )
                    {
                        break;
                    }
                }
            }
        }

        private void MainForm_Shown( object sender, EventArgs e )
        {
            // Open to mini form
            if( Properties.Settings.Default.OpenToMiniView )
            {
                ToggleForms();
            }

            if( MessageBox.Show( "Would you like to clock in?", "Confirm", MessageBoxButtons.YesNo ) == DialogResult.Yes )
            {
                ClockIn();
            }
        }

        private void SendTimesheet_Button_Click( object sender, EventArgs e )
        {
            // Calculate if this week is the first or second week of our two week period
            DateTime today = DateTime.Today;
            int iWeekNumber = ( int )( ( today.DayOfYear % 14 ) / 7 );

            // Calculate current day
            int iDayOfWeek = ( int )today.DayOfWeek - 1;
            iDayOfWeek = ( iDayOfWeek == -1 ? 6 : iDayOfWeek );

            if( iWeekNumber != 1 || iDayOfWeek != 4 )
                if( MessageBox.Show( "It isn't Friday, are you sure you want to email your time sheet now?", "Confirm", MessageBoxButtons.YesNo ) == DialogResult.No )
                    return;

            CreateEmail();
        }
    }
}