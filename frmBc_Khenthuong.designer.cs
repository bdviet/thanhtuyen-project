namespace QL_nhansu
{
    partial class frmBc_Khenthuong
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
            this.CryView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CryView
            // 
            this.CryView.ActiveViewIndex = -1;
            this.CryView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryView.DisplayGroupTree = false;
            this.CryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryView.Location = new System.Drawing.Point(0, 0);
            this.CryView.Name = "CryView";
            this.CryView.SelectionFormula = "";
            this.CryView.Size = new System.Drawing.Size(837, 589);
            this.CryView.TabIndex = 0;
            this.CryView.ViewTimeSelectionFormula = "";
            this.CryView.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmBc_Khenthuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 589);
            this.Controls.Add(this.CryView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBc_Khenthuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên Được Khen Thưởng";
            this.Load += new System.EventHandler(this.frmBc_Khenthuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryView;
    }
}