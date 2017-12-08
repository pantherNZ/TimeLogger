namespace TimeLogger
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Break_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.MiniView_Button = new System.Windows.Forms.Button();
            this.SendTimesheet_Button = new System.Windows.Forms.Button();
            this.ClockToggle_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkTimer_Label = new System.Windows.Forms.Label();
            this.BreakTimer_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Main_Timer = new System.Windows.Forms.Timer(this.components);
            this.ResetTimesheet_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Break_Button
            // 
            this.Break_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Break_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Break_Button.Location = new System.Drawing.Point(12, 9);
            this.Break_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Break_Button.Name = "Break_Button";
            this.Break_Button.Size = new System.Drawing.Size(121, 25);
            this.Break_Button.TabIndex = 1;
            this.Break_Button.Text = "Start Break";
            this.Break_Button.UseVisualStyleBackColor = true;
            this.Break_Button.Click += new System.EventHandler(this.Break_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Location = new System.Drawing.Point(12, 65);
            this.Settings_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(121, 25);
            this.Settings_Button.TabIndex = 2;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // MiniView_Button
            // 
            this.MiniView_Button.Location = new System.Drawing.Point(12, 37);
            this.MiniView_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MiniView_Button.Name = "MiniView_Button";
            this.MiniView_Button.Size = new System.Drawing.Size(121, 25);
            this.MiniView_Button.TabIndex = 3;
            this.MiniView_Button.Text = "Mini View";
            this.MiniView_Button.UseVisualStyleBackColor = true;
            this.MiniView_Button.Click += new System.EventHandler(this.MiniView_Button_Click);
            // 
            // SendTimesheet_Button
            // 
            this.SendTimesheet_Button.Location = new System.Drawing.Point(11, 93);
            this.SendTimesheet_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SendTimesheet_Button.Name = "SendTimesheet_Button";
            this.SendTimesheet_Button.Size = new System.Drawing.Size(121, 25);
            this.SendTimesheet_Button.TabIndex = 4;
            this.SendTimesheet_Button.Text = "Create Email";
            this.SendTimesheet_Button.UseVisualStyleBackColor = true;
            this.SendTimesheet_Button.Click += new System.EventHandler(this.SendTimesheet_Button_Click);
            // 
            // ClockToggle_Button
            // 
            this.ClockToggle_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClockToggle_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClockToggle_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClockToggle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClockToggle_Button.Font = new System.Drawing.Font("Perpetua", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockToggle_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClockToggle_Button.Location = new System.Drawing.Point(147, 9);
            this.ClockToggle_Button.Name = "ClockToggle_Button";
            this.ClockToggle_Button.Size = new System.Drawing.Size(205, 45);
            this.ClockToggle_Button.TabIndex = 0;
            this.ClockToggle_Button.Text = "Clock In";
            this.ClockToggle_Button.UseVisualStyleBackColor = true;
            this.ClockToggle_Button.Click += new System.EventHandler(this.ClockToggle_Button_Click);
            this.ClockToggle_Button.MouseEnter += new System.EventHandler(this.ClockToggle_Button_MouseEnter);
            this.ClockToggle_Button.MouseLeave += new System.EventHandler(this.ClockToggle_Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Work:";
            // 
            // WorkTimer_Label
            // 
            this.WorkTimer_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WorkTimer_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkTimer_Label.Font = new System.Drawing.Font("Perpetua", 22F);
            this.WorkTimer_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkTimer_Label.Location = new System.Drawing.Point(233, 64);
            this.WorkTimer_Label.Name = "WorkTimer_Label";
            this.WorkTimer_Label.Size = new System.Drawing.Size(119, 34);
            this.WorkTimer_Label.TabIndex = 6;
            this.WorkTimer_Label.Text = "00:00:00";
            this.WorkTimer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakTimer_Label
            // 
            this.BreakTimer_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BreakTimer_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BreakTimer_Label.Font = new System.Drawing.Font("Perpetua", 22F);
            this.BreakTimer_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BreakTimer_Label.Location = new System.Drawing.Point(233, 107);
            this.BreakTimer_Label.Name = "BreakTimer_Label";
            this.BreakTimer_Label.Size = new System.Drawing.Size(119, 34);
            this.BreakTimer_Label.TabIndex = 8;
            this.BreakTimer_Label.Text = "00:00:00";
            this.BreakTimer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(154, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Break:";
            // 
            // Main_Timer
            // 
            this.Main_Timer.Interval = 1000;
            this.Main_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetTimesheet_Button
            // 
            this.ResetTimesheet_Button.Location = new System.Drawing.Point(11, 121);
            this.ResetTimesheet_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ResetTimesheet_Button.Name = "ResetTimesheet_Button";
            this.ResetTimesheet_Button.Size = new System.Drawing.Size(121, 25);
            this.ResetTimesheet_Button.TabIndex = 9;
            this.ResetTimesheet_Button.Text = "Reset Timesheet";
            this.ResetTimesheet_Button.UseVisualStyleBackColor = true;
            this.ResetTimesheet_Button.Click += new System.EventHandler(this.ResetTimesheet_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 151);
            this.Controls.Add(this.ResetTimesheet_Button);
            this.Controls.Add(this.BreakTimer_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WorkTimer_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClockToggle_Button);
            this.Controls.Add(this.SendTimesheet_Button);
            this.Controls.Add(this.MiniView_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Break_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Grinding Gear Games - Time Logger";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Break_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button MiniView_Button;
        private System.Windows.Forms.Button SendTimesheet_Button;
        private System.Windows.Forms.Button ClockToggle_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WorkTimer_Label;
        private System.Windows.Forms.Label BreakTimer_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Main_Timer;
        private System.Windows.Forms.Button ResetTimesheet_Button;
    }
}

