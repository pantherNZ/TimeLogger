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

            SetDesktopLocation( Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height );
            Visible = false;
        }

        // Public methods
        public void SetMainFormReference( MainForm _mainForm )
        {
            m_mainForm = _mainForm;
        }

        // Private methods
        private void MiniForm_Load( object sender, EventArgs e )
        {

        }

        private void MainForm_Button_Click( object sender, EventArgs e )
        {
            m_mainForm.ToggleForms();
        }
    }
}
