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
        }

        private void Accept_Button_Click( object sender, EventArgs e )
        {
            // Save settings
            Properties.Settings.Default.SaveLocalCopy = SaveLocalCopy_Checkbox.Checked;
            Properties.Settings.Default.AlwaysOnTop = AlwaysOnTop_Checkbox.Checked;
            Properties.Settings.Default.RunOnStartup = RunOnStartup_Checkbox.Checked;
            Properties.Settings.Default.OpenToMiniView = OpenToMiniView_Checkbox.Checked;
            Properties.Settings.Default.ExportToTextFile = ExportToTextFile_Checkbox.Checked;
            Properties.Settings.Default.OutputExcelFile = OutputFile_Textbox.Text;
            Properties.Settings.Default.OutputDirectory = OutputDirectory_Textbox.Text;
            Properties.Settings.Default.MaxPaidBreak = int.Parse( MaxPaidBreak.Text );
        }
    }
}
