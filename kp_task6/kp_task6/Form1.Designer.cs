namespace kp_task6
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
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.swap = new System.Windows.Forms.Button();
            this.choose1 = new System.Windows.Forms.ComboBox();
            this.choose2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Menu;
            this.input.Location = new System.Drawing.Point(76, 177);
            this.input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(338, 213);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.MenuBar;
            this.output.Location = new System.Drawing.Point(636, 177);
            this.output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(331, 215);
            this.output.TabIndex = 6;
            // 
            // swap
            // 
            this.swap.BackColor = System.Drawing.SystemColors.Control;
            this.swap.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swap.Location = new System.Drawing.Point(475, 121);
            this.swap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(96, 42);
            this.swap.TabIndex = 7;
            this.swap.Text = "<>";
            this.swap.UseVisualStyleBackColor = false;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // choose1
            // 
            this.choose1.FormattingEnabled = true;
            this.choose1.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.choose1.Location = new System.Drawing.Point(184, 121);
            this.choose1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(148, 28);
            this.choose1.TabIndex = 8;
            // 
            // choose2
            // 
            this.choose2.FormattingEnabled = true;
            this.choose2.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.choose2.Location = new System.Drawing.Point(708, 121);
            this.choose2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(148, 28);
            this.choose2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1020, 463);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.ComboBox choose1;
        private System.Windows.Forms.ComboBox choose2;
    }
}

