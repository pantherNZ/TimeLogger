namespace TimeLogger
{
    partial class EmailSettingsForm
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
            this.Recipent_Textbox = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Body_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recipent_Textbox
            // 
            this.Recipent_Textbox.Location = new System.Drawing.Point(9, 9);
            this.Recipent_Textbox.Name = "Recipent_Textbox";
            this.Recipent_Textbox.Size = new System.Drawing.Size(251, 20);
            this.Recipent_Textbox.TabIndex = 19;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel_Button.Location = new System.Drawing.Point(360, 179);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(71, 25);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Accept_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accept_Button.Location = new System.Drawing.Point(285, 179);
            this.Accept_Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(71, 25);
            this.Accept_Button.TabIndex = 17;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Body_TextBox
            // 
            this.Body_TextBox.Location = new System.Drawing.Point(9, 35);
            this.Body_TextBox.Multiline = true;
            this.Body_TextBox.Name = "Body_TextBox";
            this.Body_TextBox.Size = new System.Drawing.Size(422, 139);
            this.Body_TextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(266, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email Recipent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email Body";
            // 
            // EmailSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Body_TextBox);
            this.Controls.Add(this.Recipent_Textbox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Accept_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Recipent_Textbox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.TextBox Body_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}