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
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radChinese = new System.Windows.Forms.RadioButton();
            this.radArabic = new System.Windows.Forms.RadioButton();
            this.grbLanguageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLanguageOptions
            // 
            this.grbLanguageOptions.Controls.Add(this.radArabic);
            this.grbLanguageOptions.Controls.Add(this.radChinese);
            this.grbLanguageOptions.Controls.Add(this.radFrench);
            this.grbLanguageOptions.Controls.Add(this.radEnglish);
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
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(28, 42);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(124, 42);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(58, 17);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radChinese
            // 
            this.radChinese.AutoSize = true;
            this.radChinese.Location = new System.Drawing.Point(215, 42);
            this.radChinese.Name = "radChinese";
            this.radChinese.Size = new System.Drawing.Size(63, 17);
            this.radChinese.TabIndex = 2;
            this.radChinese.TabStop = true;
            this.radChinese.Text = "Chinese";
            this.radChinese.UseVisualStyleBackColor = true;
            this.radChinese.CheckedChanged += new System.EventHandler(this.radChinese_CheckedChanged);
            // 
            // radArabic
            // 
            this.radArabic.AutoSize = true;
            this.radArabic.Location = new System.Drawing.Point(306, 42);
            this.radArabic.Name = "radArabic";
            this.radArabic.Size = new System.Drawing.Size(55, 17);
            this.radArabic.TabIndex = 3;
            this.radArabic.TabStop = true;
            this.radArabic.Text = "Arabic";
            this.radArabic.UseVisualStyleBackColor = true;
            this.radArabic.CheckedChanged += new System.EventHandler(this.radArabic_CheckedChanged);
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
            this.grbLanguageOptions.ResumeLayout(false);
            this.grbLanguageOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLanguageOptions;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.RadioButton radArabic;
        private System.Windows.Forms.RadioButton radChinese;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

