namespace EmployeeManagementView
{
    partial class FormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
			this.output = new EmployeeManagement.UCOutput();
			this.input = new EmployeeManagement.UCInput();
			this.select = new EmployeeManagement.UCSelect();
			this.SuspendLayout();
			// 
			// output
			// 
			this.output.Location = new System.Drawing.Point(11, 135);
			this.output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(546, 175);
			this.output.TabIndex = 2;
			// 
			// input
			// 
			this.input.isNull = false;
			this.input.Location = new System.Drawing.Point(147, 36);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(174, 109);
			this.input.TabIndex = 1;
			// 
			// select
			// 
			this.select.Location = new System.Drawing.Point(327, 24);
			this.select.Name = "select";
			this.select.SelectedIntex = 0;
			this.select.Size = new System.Drawing.Size(212, 121);
			this.select.TabIndex = 0;
			// 
			// FormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 330);
			this.Controls.Add(this.output);
			this.Controls.Add(this.input);
			this.Controls.Add(this.select);
			this.Name = "FormView";
			this.Text = "FormView";
			this.ResumeLayout(false);

        }
        #endregion
        private EmployeeManagement.UCInput input;
        private EmployeeManagement.UCOutput output;
        private EmployeeManagement.UCSelect select;

    }
}