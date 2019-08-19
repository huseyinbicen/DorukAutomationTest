namespace DesktopProject
{
    partial class Result
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
            this.dataGridView_Report = new System.Windows.Forms.DataGridView();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Report
            // 
            this.dataGridView_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Report.Location = new System.Drawing.Point(12, 11);
            this.dataGridView_Report.Name = "dataGridView_Report";
            this.dataGridView_Report.Size = new System.Drawing.Size(645, 307);
            this.dataGridView_Report.TabIndex = 0;
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Report.Location = new System.Drawing.Point(12, 324);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(150, 38);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExportExcel.Location = new System.Drawing.Point(545, 324);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(112, 38);
            this.btn_ExportExcel.TabIndex = 2;
            this.btn_ExportExcel.Text = "Export Excel";
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.Btn_ExportExcel_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 364);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.dataGridView_Report);
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doruk Automation Test Project";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Report;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_ExportExcel;
    }
}

