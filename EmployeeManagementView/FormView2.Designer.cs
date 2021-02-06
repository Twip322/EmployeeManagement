namespace EmployeeManagementView
{
    partial class FormView2
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
            this.components = new System.ComponentModel.Container();
            this.backupButton = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonDiagramm = new System.Windows.Forms.Button();
            this.buttonHistogramm = new System.Windows.Forms.Button();
            this.componentExcelDiagram1 = new EmployeeManagementUCsec.Excel(this.components);
            this.backupComponent1 = new EmployeeManagementUCsec.Store(this.components);
            this.componentWordSummary1 = new EmployeeManagementUCsec.WordSumm(this.components);
            this.SuspendLayout();
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(32, 46);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 0;
            this.backupButton.Text = "сохранить";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(207, 46);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(75, 23);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Excel";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonDiagramm
            // 
            this.buttonDiagramm.Location = new System.Drawing.Point(330, 47);
            this.buttonDiagramm.Name = "buttonDiagramm";
            this.buttonDiagramm.Size = new System.Drawing.Size(86, 21);
            this.buttonDiagramm.TabIndex = 2;
            this.buttonDiagramm.Text = "Диаграмма";
            this.buttonDiagramm.UseVisualStyleBackColor = true;
            this.buttonDiagramm.Click += new System.EventHandler(this.buttonDiagramm_Click);
            // 
            // buttonHistogramm
            // 
            this.buttonHistogramm.Location = new System.Drawing.Point(151, 137);
            this.buttonHistogramm.Name = "buttonHistogramm";
            this.buttonHistogramm.Size = new System.Drawing.Size(75, 23);
            this.buttonHistogramm.TabIndex = 3;
            this.buttonHistogramm.Text = "button1";
            this.buttonHistogramm.UseVisualStyleBackColor = true;
            this.buttonHistogramm.Click += new System.EventHandler(this.buttonHistogramm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 280);
            this.Controls.Add(this.buttonHistogramm);
            this.Controls.Add(this.buttonDiagramm);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.backupButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private EmployeeManagementUCsec.Store backupComponent;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonDiagramm;
        private System.Windows.Forms.Button buttonHistogramm;
        private EmployeeManagementUCsec.Excel ComponentExcelDiagram;
        private EmployeeManagementUCsec.Excel componentExcelDiagram1;
        private EmployeeManagementUCsec.Store backupComponent1;
        private EmployeeManagementUCsec.WordSumm componentWordSummary1;
    }
}