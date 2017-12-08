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
    public partial class EmailSettingsForm : Form
    {
        public EmailSettingsForm()
        {
            InitializeComponent();

            Body_TextBox.Text = Properties.Settings.Default.EmailBody;
            Recipient_Textbox.Text = Properties.Settings.Default.EmailRecipient;
        }

        private void Accept_Button_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.EmailBody = Body_TextBox.Text;
            Properties.Settings.Default.EmailRecipient = Recipient_Textbox.Text;
        }
    }
}
