namespace DBGray
{
    partial class DBTablesForm
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
            this.TablesLB = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TablesLB
            // 
            this.TablesLB.FormattingEnabled = true;
            this.TablesLB.Location = new System.Drawing.Point(12, 12);
            this.TablesLB.Name = "TablesLB";
            this.TablesLB.Size = new System.Drawing.Size(120, 225);
            this.TablesLB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBTablesForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablesLB);
            this.Name = "DBTablesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTbls;
        private System.Windows.Forms.ListBox TablesLB;
        private System.Windows.Forms.Button button1;
    }
}