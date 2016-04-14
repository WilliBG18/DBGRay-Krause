namespace DBGray
{
    partial class ViewTableForm
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
            this.TuplesLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TuplesLB
            // 
            this.TuplesLB.FormattingEnabled = true;
            this.TuplesLB.Location = new System.Drawing.Point(0, 0);
            this.TuplesLB.Name = "TuplesLB";
            this.TuplesLB.Size = new System.Drawing.Size(412, 264);
            this.TuplesLB.TabIndex = 0;
            // 
            // ViewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 325);
            this.Controls.Add(this.TuplesLB);
            this.Name = "ViewTableForm";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TuplesLB;
    }
}