namespace EmployeeManagement
{
    partial class UCInput
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(57, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(208, 26);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(312, 30);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(107, 24);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Без даты";
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(57, 223);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(362, 26);
            this.textBoxState.TabIndex = 2;
            this.textBoxState.Text = "Cостояние";
            // 
            // UCInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textBox);
            this.Name = "UCInput";
            this.Size = new System.Drawing.Size(525, 325);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxState;
    }
}
