namespace PathExist
{
    partial class MyForm
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
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.clb2 = new System.Windows.Forms.CheckedListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clb1
            // 
            this.clb1.CheckOnClick = true;
            this.clb1.FormattingEnabled = true;
            this.clb1.Location = new System.Drawing.Point(26, 25);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(227, 94);
            this.clb1.TabIndex = 0;
            // 
            // clb2
            // 
            this.clb2.CheckOnClick = true;
            this.clb2.FormattingEnabled = true;
            this.clb2.Location = new System.Drawing.Point(339, 25);
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(209, 94);
            this.clb2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(119, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Слои:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(430, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(36, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Поля:";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(57, 200);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "Считать";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(454, 200);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Проверка";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(275, 188);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Обзор";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(26, 146);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(522, 20);
            this.txtb1.TabIndex = 7;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(26, 229);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.ReadOnly = true;
            this.txb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb2.Size = new System.Drawing.Size(539, 110);
            this.txb2.TabIndex = 8;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 357);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.clb2);
            this.Controls.Add(this.clb1);
            this.Name = "MyForm";
            this.Text = "PathExist v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clb1;
        public System.Windows.Forms.CheckedListBox clb2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Button btn_browse;
        public System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox txb2;
    }
}