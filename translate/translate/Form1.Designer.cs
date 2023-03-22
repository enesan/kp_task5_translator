namespace translate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeLanguage1 = new System.Windows.Forms.ComboBox();
            this.changeLanguage2 = new System.Windows.Forms.ComboBox();
            this.textWrite = new System.Windows.Forms.TextBox();
            this.textRead = new System.Windows.Forms.TextBox();
            this.cleanOut = new System.Windows.Forms.Label();
            this.swapLanguage = new System.Windows.Forms.Label();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeLanguage1
            // 
            this.changeLanguage1.FormattingEnabled = true;
            this.changeLanguage1.Items.AddRange(new object[] {
            "russian",
            "english",
            "deutsch"});
            this.changeLanguage1.Location = new System.Drawing.Point(10, 15);
            this.changeLanguage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeLanguage1.Name = "changeLanguage1";
            this.changeLanguage1.Size = new System.Drawing.Size(156, 28);
            this.changeLanguage1.TabIndex = 0;
            // 
            // changeLanguage2
            // 
            this.changeLanguage2.FormattingEnabled = true;
            this.changeLanguage2.Items.AddRange(new object[] {
            "russian",
            "english",
            "deutsch"});
            this.changeLanguage2.Location = new System.Drawing.Point(212, 15);
            this.changeLanguage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeLanguage2.Name = "changeLanguage2";
            this.changeLanguage2.Size = new System.Drawing.Size(156, 28);
            this.changeLanguage2.TabIndex = 1;
            // 
            // textWrite
            // 
            this.textWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWrite.Location = new System.Drawing.Point(10, 78);
            this.textWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textWrite.Multiline = true;
            this.textWrite.Name = "textWrite";
            this.textWrite.Size = new System.Drawing.Size(156, 110);
            this.textWrite.TabIndex = 2;
            this.textWrite.TextChanged += new System.EventHandler(this.textWrite_TextChanged);
            // 
            // textRead
            // 
            this.textRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRead.Location = new System.Drawing.Point(212, 78);
            this.textRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRead.Multiline = true;
            this.textRead.Name = "textRead";
            this.textRead.Size = new System.Drawing.Size(155, 110);
            this.textRead.TabIndex = 3;
            // 
            // cleanOut
            // 
            this.cleanOut.AutoSize = true;
            this.cleanOut.BackColor = System.Drawing.Color.PowderBlue;
            this.cleanOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cleanOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cleanOut.Location = new System.Drawing.Point(142, 52);
            this.cleanOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cleanOut.Name = "cleanOut";
            this.cleanOut.Size = new System.Drawing.Size(25, 25);
            this.cleanOut.TabIndex = 5;
            this.cleanOut.Text = "×";
            this.cleanOut.Click += new System.EventHandler(this.cleanOut_Click);
            // 
            // swapLanguage
            // 
            this.swapLanguage.AutoSize = true;
            this.swapLanguage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.swapLanguage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.swapLanguage.Location = new System.Drawing.Point(176, 15);
            this.swapLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swapLanguage.Name = "swapLanguage";
            this.swapLanguage.Size = new System.Drawing.Size(30, 25);
            this.swapLanguage.TabIndex = 6;
            this.swapLanguage.Text = "⇄";
            this.swapLanguage.Click += new System.EventHandler(this.swapLanguage_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTranslate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTranslate.Location = new System.Drawing.Point(131, 205);
            this.buttonTranslate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(118, 27);
            this.buttonTranslate.TabIndex = 7;
            this.buttonTranslate.Text = "translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(381, 251);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.swapLanguage);
            this.Controls.Add(this.cleanOut);
            this.Controls.Add(this.textRead);
            this.Controls.Add(this.textWrite);
            this.Controls.Add(this.changeLanguage2);
            this.Controls.Add(this.changeLanguage1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "translate^^";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox changeLanguage1;
        private ComboBox changeLanguage2;
        private TextBox textWrite;
        private TextBox textRead;
        private Label cleanOut;
        private Label swapLanguage;
        private Button buttonTranslate;
    }
}