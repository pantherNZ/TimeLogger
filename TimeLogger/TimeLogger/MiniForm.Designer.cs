namespace TimeLogger
{
    partial class MiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniForm));
            this.ClockToggle_Button = new System.Windows.Forms.Button();
            this.Break_Button = new System.Windows.Forms.Button();
            this.MainForm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockToggle_Button
            // 
            this.ClockToggle_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClockToggle_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClockToggle_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClockToggle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClockToggle_Button.Font = new System.Drawing.Font("Perpetua", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockToggle_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClockToggle_Button.Location = new System.Drawing.Point(6, 6);
            this.ClockToggle_Button.Name = "ClockToggle_Button";
            this.ClockToggle_Button.Size = new System.Drawing.Size(205, 45);
            this.ClockToggle_Button.TabIndex = 1;
            this.ClockToggle_Button.Text = "Clock In";
            this.ClockToggle_Button.UseVisualStyleBackColor = true;
            this.ClockToggle_Button.Click += new System.EventHandler(this.ClockToggle_Button_Click);
            this.ClockToggle_Button.MouseEnter += new System.EventHandler(this.ClockToggle_Button_MouseEnter);
            this.ClockToggle_Button.MouseLeave += new System.EventHandler(this.ClockToggle_Button_MouseLeave);
            // 
            // Break_Button
            // 
            this.Break_Button.BackgroundImage = global::TimeLogger.Properties.Resources.BreakImage;
            this.Break_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Break_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Break_Button.Location = new System.Drawing.Point(215, 31);
            this.Break_Button.Name = "Break_Button";
            this.Break_Button.Size = new System.Drawing.Size(21, 21);
            this.Break_Button.TabIndex = 2;
            this.Break_Button.UseVisualStyleBackColor = true;
            this.Break_Button.Click += new System.EventHandler(this.Break_Button_Click);
            // 
            // MainForm_Button
            // 
            this.MainForm_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainForm_Button.BackgroundImage = global::TimeLogger.Properties.Resources.EnlargeImage;
            this.MainForm_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainForm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainForm_Button.Location = new System.Drawing.Point(215, 5);
            this.MainForm_Button.Name = "MainForm_Button";
            this.MainForm_Button.Size = new System.Drawing.Size(21, 21);
            this.MainForm_Button.TabIndex = 0;
            this.MainForm_Button.UseVisualStyleBackColor = false;
            this.MainForm_Button.Click += new System.EventHandler(this.MainForm_Button_Click);
            // 
            // MiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(237, 53);
            this.ControlBox = false;
            this.Controls.Add(this.Break_Button);
            this.Controls.Add(this.ClockToggle_Button);
            this.Controls.Add(this.MainForm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainForm_Button;
        private System.Windows.Forms.Button ClockToggle_Button;
        private System.Windows.Forms.Button Break_Button;
    }
}