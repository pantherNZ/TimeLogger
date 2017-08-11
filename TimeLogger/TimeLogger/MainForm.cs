using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;

using System.IO;
using System.Net.Mail;

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
        private static State m_currentState = State.ClockedOut;
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

            // Store registry key in order to run on Windows startup
            //RegistryKey rk = Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
            // rk.SetValue("GGG Time Logger", Application.ExecutablePath.ToString());
        }

        // Public methods
        public void ToggleForms()
        {
            m_miniForm.Visible = !m_miniForm.Visible;
            Visible = !Visible;
        }

        public void SendTimesheet()
        {
           // try
           // {
           //     DateTime today = DateTime.Today;
           //
           //     // "gggpayroll@gmail.com"
           //     MailMessage email = new MailMessage( "enkrypted1@gmail.com", "Alex.Denford@xtra.co.nz" );
           //
           //     email.Subject = "Alex Denford - Timesheet";
           //     email.Body = "Hello, here is my timesheet for " + today.Date.AddDays( -11 ).ToShortDateString() +
           //                  " to " + today.Date.AddDays( 3 ).ToShortDateString() + "\n\nThank you!\n --\nAlex Denford\n\n" +
           //                  "*This email and timesheet were generated automatically by Alex's program, please send any issues or responses to: Alex.Denford@xtra.co.nz*";
           //     email.Attachments.Add( new Attachment( s_strExcelPath ) );
           //
           //     SmtpClient MailClient = new SmtpClient( "smtp.gmail.com", 587 );
           //     MailClient.EnableSsl = true;
           //     MailClient.Timeout = 20000;
           //     MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
           //     MailClient.UseDefaultCredentials = false;
           //     MailClient.Credentials = new System.Net.NetworkCredential( "enkrypted1@gmail.com", "b3q6456b" );
           //     MailClient.Send( email );
           // }
           // catch( Exception ex )
           // {
           //     MessageBox.Show( "Error with email automation: " + ex.ToString(), "Email Error", MessageBoxButtons.OK );
           // }
        }

        // Private methods
        private void FormClosingHandler( object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            // Try to load the timesheet excel file

            // Give a warning if not found (need to change settings!)
        }

        private void MiniView_Button_Click( object sender, EventArgs e )
        {
            ToggleForms();
        }

        private void ToggleClockState()
        {
            if( m_currentState == State.ClockedIn )
                ClockOut();
            else
                ClockIn();
        }

        // Toggle break (from clocked in to break & break to clock in)
        private void ToggleBreakState()
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
            m_startTime = DateTime.Now;
            Main_Timer.Start();
        }

        // Handles clocking out
        private void ClockOut()
        {
            if( MessageBox.Show( "Are you sure you want to clock out?", "Confirm Clock Out", MessageBoxButtons.YesNo ) == DialogResult.Yes )
            {
                m_currentState = State.ClockedOut;
                ClockToggle_Button.Text = "Clock In";
                m_endTime = DateTime.Now;
                Main_Timer.Stop();
                WorkTimer_Label.Text = BreakTimer_Label.Text = "00:00:00";
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
            trans
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        // Timer
        private void timer1_Tick( object sender, EventArgs e )
        {
            // Increment main timer
            var current_time = DateTime.Now;
            WorkTimer_Label.Text = ( current_time - m_startTime ).ToString();

            // Increment break timer if on break
            if( m_currentState == State.OnBreak )
            {
                BreakTimer_Label.Text = ( current_time - m_breakStartTime ).ToString();
            }
        }

        // Take break
        private void Break_Button_Click( object sender, EventArgs e )
        {
            ToggleBreakState();
        }
    }
}


/*
                        s_EndTime = DateTime.Now;
                        s_dWorkLengthHours = ( s_EndTime.TimeOfDay - s_StartTime.TimeOfDay ).TotalHours;
                        ClockIn_Text.Text = "Clock In";

                        DateTime today = DateTime.Today;

                        // Write data to text file
                        string file_path = Environment.GetFolderPath( Environment.SpecialFolder.Desktop );

                        using( System.IO.StreamWriter file = new System.IO.StreamWriter( file_path + @"\GGGTimeLogger.txt", true ) )
                        {
                            file.WriteLine( "Date: " + today.ToString( "MMMM dd" ) + 
                                            "       Start Time: " + s_StartTime.ToString( "hh:mm tt" ) + 
                                            "       End Time: " + s_EndTime.ToString( "hh:mm tt" ) +
                                            "       Total Break: " + ( int )s_dBreakLengthMinutes + " minutes" +
                                            "       Total Work: " + s_dWorkLengthHours.ToString( "0.00" ) + " hours" );
                        }

                        // While loop to allow user to retry if file is open by another process
                        while( true )
                        {
                            try
                            {
                                // Write data to excel spreadsheet
                                s_strExcelPath = file_path + @"\Timesheet v2.5.xlsx";
                                XSSFWorkbook hssfwb;

                                using( FileStream file = new FileStream(s_strExcelPath , FileMode.Open, FileAccess.Read ) )
                                {
                                    // hssfwb = new HSSFWorkbook( file );
                                    hssfwb = new XSSFWorkbook( file );
                                    file.Close();
                                }

                                ISheet sheet = hssfwb.GetSheetAt( 0 );
                                sheet.ForceFormulaRecalculation = true;
                                
                                // Calculate if this week is the first or second week of our two week period
                                DateTime base_first_monday = new DateTime( 2016, 1, 18 );
                                int iWeekNumber = ( ( today.DayOfYear - base_first_monday.DayOfYear ) % 14 <= 6 ? 0 : 1 );

                                // Calculate current day
                                int iDayOfWeek = ( int )today.DayOfWeek - 1;
                                iDayOfWeek = ( iDayOfWeek == -1 ? 6 : iDayOfWeek );

                                // Set week starting date
                                if( iWeekNumber == 0 && iDayOfWeek == 0)
                                {
                                    sheet.GetRow( 7 ).GetCell( 8 ).SetCellValue( today.Date.ToShortDateString() ); 
                                }

                                int iRow = 10 + iDayOfWeek + iWeekNumber * 8;

                                // Main Start & End Times
                                sheet.GetRow( iRow ).GetCell( 2 ).SetCellValue( s_StartTime.ToString( "hh:mm tt" ) ); 
                                sheet.GetRow( iRow ).GetCell( 3 ).SetCellValue( s_EndTime.ToString( "hh:mm tt" ) );

                                // Secondary Start & End Times
                                //sheet.GetRow( iRow ).GetCell( 4 ).SetCellValue( EndTime.ToString( "hh:mm tt" ) ); 
                                //sheet.GetRow( iRow ).GetCell( 5 ).SetCellValue( EndTime.ToString( "hh:mm tt" ) ); 

                                // Unpaid break
                                int iUnpaidBreak = ( int )Math.Max( 0.0, s_dBreakLengthMinutes - 30.0 );
                                sheet.GetRow( iRow ).GetCell( 7 ).SetCellValue( iUnpaidBreak );

                                File.Delete( s_strExcelPath );

                                // Save
                                using( FileStream file = new FileStream( s_strExcelPath, FileMode.CreateNew, FileAccess.Write ) )
                                {
                                    hssfwb.Write( file );
                                    file.Close();
                                }

                                // If Friday, email to GGGPayroll
                               // if( iWeekNumber == 1 && iDayOfWeek == 4 )
                                if(true)
                                {
                                    ClockIn_Text.Text = "Sending Email";
                                    //ClockIn_Text.Font = new Font( "Perpetua", 22, FontStyle.Regular );
                                    s_CurrentState = StateType.SendingEmail;

                                    Event_Timer.Enabled = true;
                                    Event_Timer.Start();
                                }

                                break;
                            }
                            catch( IOException )
                            {
                                // Handle IO Exception with elegent message box
                                string strText = "\"Timesheet v2.5.xlsx\" is already in use. Please close the file and try again";

                                if( MessageBox.Show( strText, "File IO Error", MessageBoxButtons.RetryCancel ) == DialogResult.Cancel )
                                {
                                    break;
                                }
                            }
*/