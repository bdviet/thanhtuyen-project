namespace QL_nhansu
{
    partial class frmBc_Kyluat
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
            this.CryViewKL = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CryViewKL
            // 
            this.CryViewKL.ActiveViewIndex = -1;
            this.CryViewKL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryViewKL.DisplayGroupTree = false;
            this.CryViewKL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryViewKL.Location = new System.Drawing.Point(0, 0);
            this.CryViewKL.Name = "CryViewKL";
            this.CryViewKL.SelectionFormula = "";
            this.CryViewKL.Size = new System.Drawing.Size(835, 583);
            this.CryViewKL.TabIndex = 0;
            this.CryViewKL.ViewTimeSelectionFormula = "";
            // 
            // frmBc_Kyluat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 583);
            this.Controls.Add(this.CryViewKL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBc_Kyluat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên Bị Kỷ Luật";
            this.Load += new System.EventHandler(this.frmBc_Kyluat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryViewKL;
    }
}