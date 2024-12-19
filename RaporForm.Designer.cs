namespace fitnessuygulamasi
{
    partial class RaporForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ReportLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ReportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Location = new System.Drawing.Point(13, 13);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(189, 16);
            this.ReportLabel.TabIndex = 0;
            this.ReportLabel.Text = "Rapor burada görüntülenecek.";
            
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.ReportLabel);
            this.Name = "RaporForm";
            this.Text = "Egzersiz Raporu";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
