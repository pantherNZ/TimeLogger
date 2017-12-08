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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Load from settings
            SaveLocalCopy_Checkbox.Checked = Properties.Settings.Default.SaveLocalCopy;
            AlwaysOnTop_Checkbox.Checked = Properties.Settings.Default.AlwaysOnTop;
            RunOnStartup_Checkbox.Checked = Properties.Settings.Default.RunOnStartup;
            OpenToMiniView_Checkbox.Checked = Properties.Settings.Default.OpenToMiniView;
            ExportToTextFile_Checkbox.Checked = Properties.Settings.Default.ExportToTextFile;
            OutputFile_Textbox.Text = Properties.Settings.Default.OutputExcelFile;
            OutputDirectory_Textbox.Text = Properties.Settings.Default.OutputDirectory;
            MaxPaidBreak.Text = Properties.Settings.Default.MaxPaidBreak.ToString();
            Name_TextBox.Text = Properties.Settings.Default.Name;
        }

        private void Accept_Button_Click( object sender, EventArgs e )
        {
            if( Name_TextBox.Text.Length == 0 )
            {
                Name_TextBox.BackColor = Color.Red;
                DialogResult = DialogResult.None;
                return;
            }

            // Save settings
            Properties.Settings.Default.SaveLocalCopy = SaveLocalCopy_Checkbox.Checked;
            Properties.Settings.Default.AlwaysOnTop = AlwaysOnTop_Checkbox.Checked;
            Properties.Settings.Default.RunOnStartup = RunOnStartup_Checkbox.Checked;
            Properties.Settings.Default.OpenToMiniView = OpenToMiniView_Checkbox.Checked;
            Properties.Settings.Default.ExportToTextFile = ExportToTextFile_Checkbox.Checked;
            Properties.Settings.Default.OutputExcelFile = OutputFile_Textbox.Text;
            Properties.Settings.Default.OutputDirectory = OutputDirectory_Textbox.Text;
            Properties.Settings.Default.MaxPaidBreak = int.Parse( MaxPaidBreak.Text );
            Properties.Settings.Default.Name = Name_TextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void SelectDirectory_Button_Click( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Properties.Settings.Default.OutputDirectory;
            openFileDialog1.Filter = "Excel Files (.xls/.xlsx)|*.xls*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                var fileNameStart = openFileDialog1.FileName.LastIndexOf( '\\' );
                OutputDirectory_Textbox.Text = openFileDialog1.FileName.Substring( 0, fileNameStart ) + "\\";
                OutputFile_Textbox.Text = openFileDialog1.FileName.Substring( fileNameStart + 1 );
            }
        }

        private void EmailSettings_Button_Click( object sender, EventArgs e )
        {
            var settingsForm = new EmailSettingsForm();
            settingsForm.ShowDialog();
            this.DialogResult = DialogResult.None;
        }

        private void Cancel_Button_Click( object sender, EventArgs e )
        {
            if( Properties.Settings.Default.Name.Length == 0 )
            {
                Name_TextBox.BackColor = Color.Red;
                DialogResult = DialogResult.None;
            }
        }
    }
}
