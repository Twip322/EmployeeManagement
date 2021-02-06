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
            this.textBoxDatePicker = new System.Windows.Forms.TextBox();
            this.checkBoxNull = new System.Windows.Forms.CheckBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDatePicker
            // 
            this.textBoxDatePicker.Location = new System.Drawing.Point(4, 4);
            this.textBoxDatePicker.Name = "textBoxDatePicker";
            this.textBoxDatePicker.Size = new System.Drawing.Size(143, 20);
            this.textBoxDatePicker.TabIndex = 0;
            this.textBoxDatePicker.TextChanged += new System.EventHandler(this.textBoxDatePicker_TextChanged);
            // 
            // checkBoxNull
            // 
            this.checkBoxNull.AutoSize = true;
            this.checkBoxNull.Location = new System.Drawing.Point(4, 31);
            this.checkBoxNull.Name = "checkBoxNull";
            this.checkBoxNull.Size = new System.Drawing.Size(57, 17);
            this.checkBoxNull.TabIndex = 1;
            this.checkBoxNull.Text = "isNull?";
            this.checkBoxNull.UseVisualStyleBackColor = true;
            this.checkBoxNull.CheckedChanged += new System.EventHandler(this.checkBoxNull_CheckedChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(4, 55);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 2;
            // 
            // ControlDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.checkBoxNull);
            this.Controls.Add(this.textBoxDatePicker);
            this.Name = "ControlDatePicker";
            this.Size = new System.Drawing.Size(150, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDatePicker;
        private System.Windows.Forms.CheckBox checkBoxNull;
        private System.Windows.Forms.Label labelInfo;
    }
}
