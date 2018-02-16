namespace HelloWorldIntThomasA
{
    partial class frmHelloWorldInt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLanguageOptions = new System.Windows.Forms.GroupBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grbLanguageOptions
            // 
            this.grbLanguageOptions.Location = new System.Drawing.Point(50, 137);
            this.grbLanguageOptions.Name = "grbLanguageOptions";
            this.grbLanguageOptions.Size = new System.Drawing.Size(397, 100);
            this.grbLanguageOptions.TabIndex = 0;
            this.grbLanguageOptions.TabStop = false;
            this.grbLanguageOptions.Text = "Languages";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(119, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(256, 62);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.grbLanguageOptions);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLanguageOptions;
        private System.Windows.Forms.Label lblGreeting;
    }
}

