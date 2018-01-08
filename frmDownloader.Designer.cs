namespace Downloader
{
    partial class frmDownloader
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstUrls = new System.Windows.Forms.CheckedListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lstUrls, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDownload, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstUrls
            // 
            this.lstUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.Location = new System.Drawing.Point(3, 38);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(436, 149);
            this.lstUrls.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDownload.Location = new System.Drawing.Point(3, 193);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(436, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnReload, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectAll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.AutoSize = true;
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.Location = new System.Drawing.Point(382, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(51, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectAll.Location = new System.Drawing.Point(3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(61, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // frmDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDownloader";
            this.Text = "Downloader";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckedListBox lstUrls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnReload;
    }
}

