namespace Perevodchik_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.choiseLang1 = new System.Windows.Forms.ComboBox();
            this.choiseLang2 = new System.Windows.Forms.ComboBox();
            this.swapLangButton = new System.Windows.Forms.Button();
            this.PoleVvoda = new System.Windows.Forms.TextBox();
            this.PoleVyvoda = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choiseLang1
            // 
            this.choiseLang1.FormattingEnabled = true;
            this.choiseLang1.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.choiseLang1.Location = new System.Drawing.Point(36, 33);
            this.choiseLang1.Name = "choiseLang1";
            this.choiseLang1.Size = new System.Drawing.Size(202, 21);
            this.choiseLang1.TabIndex = 0;
            // 
            // choiseLang2
            // 
            this.choiseLang2.FormattingEnabled = true;
            this.choiseLang2.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.choiseLang2.Location = new System.Drawing.Point(445, 33);
            this.choiseLang2.Name = "choiseLang2";
            this.choiseLang2.Size = new System.Drawing.Size(202, 21);
            this.choiseLang2.TabIndex = 1;
            // 
            // swapLangButton
            // 
            this.swapLangButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.swapLangButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.swapLangButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swapLangButton.Location = new System.Drawing.Point(284, 17);
            this.swapLangButton.Name = "swapLangButton";
            this.swapLangButton.Size = new System.Drawing.Size(120, 55);
            this.swapLangButton.TabIndex = 2;
            this.swapLangButton.Text = "Поменять";
            this.swapLangButton.UseVisualStyleBackColor = false;
            this.swapLangButton.Click += new System.EventHandler(this.swapLangButton_Click);
            // 
            // PoleVvoda
            // 
            this.PoleVvoda.Location = new System.Drawing.Point(36, 94);
            this.PoleVvoda.Multiline = true;
            this.PoleVvoda.Name = "PoleVvoda";
            this.PoleVvoda.Size = new System.Drawing.Size(227, 260);
            this.PoleVvoda.TabIndex = 3;
            this.PoleVvoda.TextChanged += new System.EventHandler(this.PoleVvoda_TextChanged_1);
            // 
            // PoleVyvoda
            // 
            this.PoleVyvoda.Location = new System.Drawing.Point(425, 93);
            this.PoleVyvoda.Multiline = true;
            this.PoleVyvoda.Name = "PoleVyvoda";
            this.PoleVyvoda.Size = new System.Drawing.Size(222, 260);
            this.PoleVyvoda.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(273, 93);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(33, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "X";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(680, 376);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.PoleVyvoda);
            this.Controls.Add(this.PoleVvoda);
            this.Controls.Add(this.swapLangButton);
            this.Controls.Add(this.choiseLang2);
            this.Controls.Add(this.choiseLang1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choiseLang1;
        private System.Windows.Forms.ComboBox choiseLang2;
        private System.Windows.Forms.Button swapLangButton;
        private System.Windows.Forms.TextBox PoleVvoda;
        private System.Windows.Forms.TextBox PoleVyvoda;
        private System.Windows.Forms.Button clearButton;
    }
}

