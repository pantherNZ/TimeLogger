using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLogger
{
    public partial class MiniForm : Form
    {
        // Members
        private static MainForm m_mainForm;

        // Methods
        // Constructor
        public MiniForm()
        {
            InitializeComponent();
            SetDesktopLocation( Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height );
            Visible = false;
        }

        // Public methods
        public void SetMainFormReference( MainForm _mainForm )
        {
            m_mainForm = _mainForm;
        }

        public void SetButtonText( string text )
        {
            ClockToggle_Button.Text = text;
        }

        // Private methods
        private void MiniForm_Load( object sender, EventArgs e )
        {

        }

        private void MainForm_Button_Click( object sender, EventArgs e )
        {
            m_mainForm.ToggleForms();
        }

        private void Break_Button_Click( object sender, EventArgs e )
        {
            m_mainForm.ToggleBreakState();
        }

        private void ClockToggle_Button_Click( object sender, EventArgs e )
        {
            if( MainForm.m_currentState == MainForm.State.OnBreak )
                m_mainForm.ToggleBreakState();
            else
                m_mainForm.ToggleClockState();
        }

        private void ClockToggle_Button_MouseEnter( object sender, EventArgs e )
        {
            ClockToggle_Button.ForeColor = Color.DodgerBlue;
        }

        private void ClockToggle_Button_MouseLeave( object sender, EventArgs e )
        {
            ClockToggle_Button.ForeColor = SystemColors.ButtonHighlight;
        }
    }
}
