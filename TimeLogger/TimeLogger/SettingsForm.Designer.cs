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
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accept_Button.Location = new System.Drawing.Point(271, 129);
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
            this.Cancel_Button.Location = new System.Drawing.Point(196, 129);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(71, 25);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
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
            this.SaveLocalCopy_Checkbox.Size = new System.Drawing.Size(102, 17);
            this.SaveLocalCopy_Checkbox.TabIndex = 6;
            this.SaveLocalCopy_Checkbox.Text = "Save local copy";
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
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(186, 47);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(45, 20);
            this.domainUpDown1.TabIndex = 9;
            this.domainUpDown1.Text = "30";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(232, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(232, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 20);
            this.button2.TabIndex = 15;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(345, 159);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown1);
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
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}