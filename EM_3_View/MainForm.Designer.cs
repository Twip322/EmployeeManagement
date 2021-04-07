namespace EM_3_View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.pdfDiagrammComponent = new components.PdfDiagrammComponent(this.components);
            this.comboBoxPlugins = new System.Windows.Forms.ComboBox();
            this.btnPluginStart = new System.Windows.Forms.Button();
            this.buttonPdfDiagram = new System.Windows.Forms.Button();
            this.buttonPdfTable = new System.Windows.Forms.Button();
            this.controlListBox1 = new ClassLibraryControlSelected.ControlListBox();
            this.exelTable = new KDAkop.ExelTable(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Location = new System.Drawing.Point(56, 217);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUnit.TabIndex = 0;
            this.buttonAddUnit.Text = "add";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            this.buttonAddUnit.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPlugins
            // 
            this.comboBoxPlugins.FormattingEnabled = true;
            this.comboBoxPlugins.Location = new System.Drawing.Point(56, 12);
            this.comboBoxPlugins.Name = "comboBoxPlugins";
            this.comboBoxPlugins.Size = new System.Drawing.Size(184, 21);
            this.comboBoxPlugins.TabIndex = 4;
            // 
            // btnPluginStart
            // 
            this.btnPluginStart.Location = new System.Drawing.Point(246, 12);
            this.btnPluginStart.Name = "btnPluginStart";
            this.btnPluginStart.Size = new System.Drawing.Size(75, 23);
            this.btnPluginStart.TabIndex = 5;
            this.btnPluginStart.Text = "Start";
            this.btnPluginStart.UseVisualStyleBackColor = true;
            this.btnPluginStart.Click += new System.EventHandler(this.btnPluginStart_Click);
            // 
            // buttonPdfDiagram
            // 
            this.buttonPdfDiagram.Location = new System.Drawing.Point(472, 135);
            this.buttonPdfDiagram.Name = "buttonPdfDiagram";
            this.buttonPdfDiagram.Size = new System.Drawing.Size(75, 23);
            this.buttonPdfDiagram.TabIndex = 2;
            this.buttonPdfDiagram.Text = "pdfDiagarm";
            this.buttonPdfDiagram.UseVisualStyleBackColor = true;
            this.buttonPdfDiagram.Click += new System.EventHandler(this.buttonPdfDiagram_Click);
            // 
            // buttonPdfTable
            // 
            this.buttonPdfTable.Location = new System.Drawing.Point(354, 135);
            this.buttonPdfTable.Name = "buttonPdfTable";
            this.buttonPdfTable.Size = new System.Drawing.Size(75, 23);
            this.buttonPdfTable.TabIndex = 3;
            this.buttonPdfTable.Text = "table";
            this.buttonPdfTable.UseVisualStyleBackColor = true;
            // 
            // controlListBox1
            // 
            this.controlListBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.controlListBox1.Location = new System.Drawing.Point(34, 44);
            this.controlListBox1.Name = "controlListBox1";
            this.controlListBox1.SelectedIndex = 0;
            this.controlListBox1.Size = new System.Drawing.Size(255, 157);
            this.controlListBox1.TabIndex = 1;
            this.controlListBox1.Load += new System.EventHandler(this.controlListBox1_Load);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(327, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPluginStart);
            this.Controls.Add(this.comboBoxPlugins);
            this.Controls.Add(this.buttonPdfTable);
            this.Controls.Add(this.buttonPdfDiagram);
            this.Controls.Add(this.controlListBox1);
            this.Controls.Add(this.buttonAddUnit);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUnit;
        private components.PdfDiagrammComponent pdfDiagrammComponent;
        private KDAkop.ExelTable exelTable;
        private System.Windows.Forms.ComboBox comboBoxPlugins;
        private System.Windows.Forms.Button btnPluginStart;
        private System.Windows.Forms.Button buttonPdfDiagram;
        private System.Windows.Forms.Button buttonPdfTable;
        public ClassLibraryControlSelected.ControlListBox controlListBox1;
        private System.Windows.Forms.Button btnReport;
    }
}