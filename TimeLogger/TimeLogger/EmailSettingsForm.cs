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
            Recipent_Textbox.Text = Properties.Settings.Default.EmailRecipent;
        }

        private void Accept_Button_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.EmailBody = Body_TextBox.Text;
            Properties.Settings.Default.EmailRecipent = Recipent_Textbox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
