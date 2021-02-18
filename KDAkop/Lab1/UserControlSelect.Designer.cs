namespace KDAkop
{
    partial class UserControlSelect
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.controlListBox1 = new ClassLibraryControlSelected.ControlListBox();
            this.controlListOfValues1 = new ClassLibraryControlSelected.ControlListOfValues();
            this.controlPhoneNumberCheck1 = new ClassLibraryControlSelected.ControlPhoneNumberCheck();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox.TabIndex = 0;
            // 
            // controlListBox1
            // 
            this.controlListBox1.Location = new System.Drawing.Point(0, 0);
            this.controlListBox1.Name = "controlListBox1";
            this.controlListBox1.SelectedIndex = 0;
            this.controlListBox1.Size = new System.Drawing.Size(244, 174);
            this.controlListBox1.TabIndex = 1;
            // 
            // controlListOfValues1
            // 
            this.controlListOfValues1.Location = new System.Drawing.Point(0, 0);
            this.controlListOfValues1.Name = "controlListOfValues1";
            this.controlListOfValues1.Size = new System.Drawing.Size(254, 192);
            this.controlListOfValues1.TabIndex = 2;
            // 
            // controlPhoneNumberCheck1
            // 
            this.controlPhoneNumberCheck1.Location = new System.Drawing.Point(0, 0);
            this.controlPhoneNumberCheck1.Name = "controlPhoneNumberCheck1";
            this.controlPhoneNumberCheck1.Size = new System.Drawing.Size(255, 117);
            this.controlPhoneNumberCheck1.TabIndex = 3;
            // 
            // UserControlSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPhoneNumberCheck1);
            this.Controls.Add(this.controlListOfValues1);
            this.Controls.Add(this.controlListBox1);
            this.Controls.Add(this.checkedListBox);
            this.Name = "UserControlSelect";
            this.Size = new System.Drawing.Size(130, 104);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private ClassLibraryControlSelected.ControlListBox controlListBox1;
        private ClassLibraryControlSelected.ControlListOfValues controlListOfValues1;
        private ClassLibraryControlSelected.ControlPhoneNumberCheck controlPhoneNumberCheck1;
    }
}
