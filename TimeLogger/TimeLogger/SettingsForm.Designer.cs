namespace TimeLogger
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.RunOnStartup_Checkbox = new System.Windows.Forms.CheckBox();
            this.ExportToTextFile_Checkbox = new System.Windows.Forms.CheckBox();
            this.SaveLocalCopy_Checkbox = new System.Windows.Forms.CheckBox();
            this.AlwaysOnTop_Checkbox = new System.Windows.Forms.CheckBox();
            this.OpenToMiniView_Checkbox = new System.Windows.Forms.CheckBox();
            this.MaxPaidBreak = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputDirectory_Textbox = new System.Windows.Forms.TextBox();
            this.SelectDirectory_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputFile_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailSettings_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accept_Button.Location = new System.Drawing.Point(185, 153);
            this.Accept_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(71, 25);
            this.Accept_Button.TabIndex = 2;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel_Button.Location = new System.Drawing.Point(269, 153);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(71, 25);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // RunOnStartup_Checkbox
            // 
            this.RunOnStartup_Checkbox.AutoSize = true;
            this.RunOnStartup_Checkbox.Location = new System.Drawing.Point(186, 8);
            this.RunOnStartup_Checkbox.Name = "RunOnStartup_Checkbox";
            this.RunOnStartup_Checkbox.Size = new System.Drawing.Size(96, 17);
            this.RunOnStartup_Checkbox.TabIndex = 4;
            this.RunOnStartup_Checkbox.Text = "Run on startup";
            this.RunOnStartup_Checkbox.UseVisualStyleBackColor = true;
            // 
            // ExportToTextFile_Checkbox
            // 
            this.ExportToTextFile_Checkbox.AutoSize = true;
            this.ExportToTextFile_Checkbox.Location = new System.Drawing.Point(186, 27);
            this.ExportToTextFile_Checkbox.Name = "ExportToTextFile_Checkbox";
            this.ExportToTextFile_Checkbox.Size = new System.Drawing.Size(104, 17);
            this.ExportToTextFile_Checkbox.TabIndex = 5;
            this.ExportToTextFile_Checkbox.Text = "Export to text file";
            this.ExportToTextFile_Checkbox.UseVisualStyleBackColor = true;
            // 
            // SaveLocalCopy_Checkbox
            // 
            this.SaveLocalCopy_Checkbox.AutoSize = true;
            this.SaveLocalCopy_Checkbox.Location = new System.Drawing.Point(10, 8);
            this.SaveLocalCopy_Checkbox.Name = "SaveLocalCopy_Checkbox";
            this.SaveLocalCopy_Checkbox.Size = new System.Drawing.Size(117, 17);
            this.SaveLocalCopy_Checkbox.TabIndex = 6;
            this.SaveLocalCopy_Checkbox.Text = "Save copy of excel";
            this.SaveLocalCopy_Checkbox.UseVisualStyleBackColor = true;
            // 
            // AlwaysOnTop_Checkbox
            // 
            this.AlwaysOnTop_Checkbox.AutoSize = true;
            this.AlwaysOnTop_Checkbox.Location = new System.Drawing.Point(10, 27);
            this.AlwaysOnTop_Checkbox.Name = "AlwaysOnTop_Checkbox";
            this.AlwaysOnTop_Checkbox.Size = new System.Drawing.Size(92, 17);
            this.AlwaysOnTop_Checkbox.TabIndex = 7;
            this.AlwaysOnTop_Checkbox.Text = "Always on top";
            this.AlwaysOnTop_Checkbox.UseVisualStyleBackColor = true;
            // 
            // OpenToMiniView_Checkbox
            // 
            this.OpenToMiniView_Checkbox.AutoSize = true;
            this.OpenToMiniView_Checkbox.Location = new System.Drawing.Point(10, 45);
            this.OpenToMiniView_Checkbox.Name = "OpenToMiniView_Checkbox";
            this.OpenToMiniView_Checkbox.Size = new System.Drawing.Size(110, 17);
            this.OpenToMiniView_Checkbox.TabIndex = 8;
            this.OpenToMiniView_Checkbox.Text = "Open to mini view";
            this.OpenToMiniView_Checkbox.UseVisualStyleBackColor = true;
            // 
            // MaxPaidBreak
            // 
            this.MaxPaidBreak.Location = new System.Drawing.Point(186, 47);
            this.MaxPaidBreak.Name = "MaxPaidBreak";
            this.MaxPaidBreak.Size = new System.Drawing.Size(45, 20);
            this.MaxPaidBreak.TabIndex = 9;
            this.MaxPaidBreak.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Max paid break (mins)";
            // 
            // OutputDirectory_Textbox
            // 
            this.OutputDirectory_Textbox.Location = new System.Drawing.Point(10, 74);
            this.OutputDirectory_Textbox.Name = "OutputDirectory_Textbox";
            this.OutputDirectory_Textbox.Size = new System.Drawing.Size(246, 20);
            this.OutputDirectory_Textbox.TabIndex = 11;
            // 
            // SelectDirectory_Button
            // 
            this.SelectDirectory_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectDirectory_Button.Location = new System.Drawing.Point(231, 100);
            this.SelectDirectory_Button.Name = "SelectDirectory_Button";
            this.SelectDirectory_Button.Size = new System.Drawing.Size(25, 20);
            this.SelectDirectory_Button.TabIndex = 12;
            this.SelectDirectory_Button.Text = "...";
            this.SelectDirectory_Button.UseVisualStyleBackColor = true;
            this.SelectDirectory_Button.Click += new System.EventHandler(this.SelectDirectory_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Output directory";
            // 
            // OutputFile_Textbox
            // 
            this.OutputFile_Textbox.Location = new System.Drawing.Point(10, 100);
            this.OutputFile_Textbox.Name = "OutputFile_Textbox";
            this.OutputFile_Textbox.Size = new System.Drawing.Size(216, 20);
            this.OutputFile_Textbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Output excel file";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Name_TextBox.Location = new System.Drawing.Point(10, 126);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(246, 20);
            this.Name_TextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // EmailSettings_Button
            // 
            this.EmailSettings_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailSettings_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EmailSettings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EmailSettings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EmailSettings_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailSettings_Button.Location = new System.Drawing.Point(10, 153);
            this.EmailSettings_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EmailSettings_Button.Name = "EmailSettings_Button";
            this.EmailSettings_Button.Size = new System.Drawing.Size(83, 25);
            this.EmailSettings_Button.TabIndex = 19;
            this.EmailSettings_Button.Text = "Email Settings";
            this.EmailSettings_Button.UseVisualStyleBackColor = true;
            this.EmailSettings_Button.Click += new System.EventHandler(this.EmailSettings_Button_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(344, 184);
            this.ControlBox = false;
            this.Controls.Add(this.EmailSettings_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputFile_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectDirectory_Button);
            this.Controls.Add(this.OutputDirectory_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxPaidBreak);
            this.Controls.Add(this.OpenToMiniView_Checkbox);
            this.Controls.Add(this.AlwaysOnTop_Checkbox);
            this.Controls.Add(this.SaveLocalCopy_Checkbox);
            this.Controls.Add(this.ExportToTextFile_Checkbox);
            this.Controls.Add(this.RunOnStartup_Checkbox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Accept_Button);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.CheckBox RunOnStartup_Checkbox;
        private System.Windows.Forms.CheckBox ExportToTextFile_Checkbox;
        private System.Windows.Forms.CheckBox SaveLocalCopy_Checkbox;
        private System.Windows.Forms.CheckBox AlwaysOnTop_Checkbox;
        private System.Windows.Forms.CheckBox OpenToMiniView_Checkbox;
        private System.Windows.Forms.DomainUpDown MaxPaidBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputDirectory_Textbox;
        private System.Windows.Forms.Button SelectDirectory_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputFile_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EmailSettings_Button;
    }
}