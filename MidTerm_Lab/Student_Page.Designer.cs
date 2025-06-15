using System;

namespace MidTerm_Lab
{
    partial class Student_Page
    {
        private System.Windows.Forms.Label HeaderLbl;
        public System.Windows.Forms.DataGridView StudentGrid;

        private void InitializeComponent()
        {
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.StudentGrid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.SuspendLayout();

            // Header Label
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLbl.Location = new System.Drawing.Point(200, 20);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(188, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Student List";

            // DataGridView
            this.StudentGrid.AllowUserToAddRows = false;
            this.StudentGrid.AllowUserToDeleteRows = false;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(30, 80);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.ReadOnly = true;
            this.StudentGrid.RowHeadersVisible = false;
            this.StudentGrid.Size = new System.Drawing.Size(540, 300);
            this.StudentGrid.TabIndex = 1;

            // Student_Page
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.HeaderLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Student_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Page";
            this.Load += new System.EventHandler(this.Student_Page_Load);

            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

