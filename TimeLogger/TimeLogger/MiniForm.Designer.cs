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
            this.MainForm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainForm_Button
            // 
            this.MainForm_Button.Location = new System.Drawing.Point(100, 83);
            this.MainForm_Button.Name = "MainForm_Button";
            this.MainForm_Button.Size = new System.Drawing.Size(75, 23);
            this.MainForm_Button.TabIndex = 0;
            this.MainForm_Button.Text = "button1";
            this.MainForm_Button.UseVisualStyleBackColor = true;
            this.MainForm_Button.Click += new System.EventHandler(this.MainForm_Button_Click);
            // 
            // MiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(276, 253);
            this.ControlBox = false;
            this.Controls.Add(this.MainForm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MiniForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainForm_Button;
    }
}