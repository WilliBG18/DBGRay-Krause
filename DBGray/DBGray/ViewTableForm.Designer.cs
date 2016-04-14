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
            this.insert_btn = new System.Windows.Forms.Button();
            this.rfs_btn = new System.Windows.Forms.Button();
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
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(325, 290);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 1;
            this.insert_btn.Text = "Insert Tuple";
            this.insert_btn.UseVisualStyleBackColor = true;
            // 
            // rfs_btn
            // 
            this.rfs_btn.Location = new System.Drawing.Point(12, 290);
            this.rfs_btn.Name = "rfs_btn";
            this.rfs_btn.Size = new System.Drawing.Size(75, 23);
            this.rfs_btn.TabIndex = 2;
            this.rfs_btn.Text = "Refresh";
            this.rfs_btn.UseVisualStyleBackColor = true;
            // 
            // ViewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 325);
            this.Controls.Add(this.rfs_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.TuplesLB);
            this.Name = "ViewTableForm";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TuplesLB;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button rfs_btn;
    }
}