namespace MongoTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btTest1 = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.CSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CDocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btTest2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btReadDocs = new System.Windows.Forms.Button();
            this.btSync = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConStr1 = new System.Windows.Forms.TextBox();
            this.tbConStr2 = new System.Windows.Forms.TextBox();
            this.tbDBName1 = new System.Windows.Forms.TextBox();
            this.tbDBName2 = new System.Windows.Forms.TextBox();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDisselectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTest1
            // 
            this.btTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTest1.Location = new System.Drawing.Point(764, 8);
            this.btTest1.Name = "btTest1";
            this.btTest1.Size = new System.Drawing.Size(94, 24);
            this.btTest1.TabIndex = 0;
            this.btTest1.Text = "测试";
            this.btTest1.UseVisualStyleBackColor = true;
            this.btTest1.Click += new System.EventHandler(this.btTest1_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSelect,
            this.CDocumentName});
            this.dgvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocuments.Location = new System.Drawing.Point(63, 73);
            this.dgvDocuments.Name = "dgvDocuments";
            this.tableLayoutPanel1.SetRowSpan(this.dgvDocuments, 4);
            this.dgvDocuments.RowTemplate.Height = 23;
            this.dgvDocuments.Size = new System.Drawing.Size(535, 284);
            this.dgvDocuments.TabIndex = 1;
            // 
            // CSelect
            // 
            this.CSelect.FalseValue = "false";
            this.CSelect.HeaderText = "選擇";
            this.CSelect.Name = "CSelect";
            this.CSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CSelect.TrueValue = "true";
            // 
            // CDocumentName
            // 
            this.CDocumentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDocumentName.HeaderText = "數據表";
            this.CDocumentName.Name = "CDocumentName";
            this.CDocumentName.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDocuments, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btTest1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btTest2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btReadDocs, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btSync, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbConStr1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbConStr2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDBName1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDBName2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLogs, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btSelectAll, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btDisselectAll, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 551);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btTest2
            // 
            this.btTest2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTest2.Location = new System.Drawing.Point(764, 38);
            this.btTest2.Name = "btTest2";
            this.btTest2.Size = new System.Drawing.Size(94, 24);
            this.btTest2.TabIndex = 2;
            this.btTest2.Text = "测试";
            this.btTest2.UseVisualStyleBackColor = true;
            this.btTest2.Click += new System.EventHandler(this.btTest2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "源數據庫";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "目標數據庫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "源數據庫名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "目標數據庫名";
            // 
            // btReadDocs
            // 
            this.btReadDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReadDocs.Location = new System.Drawing.Point(664, 333);
            this.btReadDocs.Name = "btReadDocs";
            this.btReadDocs.Size = new System.Drawing.Size(94, 24);
            this.btReadDocs.TabIndex = 7;
            this.btReadDocs.Text = "讀取Documents";
            this.btReadDocs.UseVisualStyleBackColor = true;
            this.btReadDocs.Click += new System.EventHandler(this.btReadDocs_Click);
            // 
            // btSync
            // 
            this.btSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSync.Location = new System.Drawing.Point(764, 333);
            this.btSync.Name = "btSync";
            this.btSync.Size = new System.Drawing.Size(94, 24);
            this.btSync.TabIndex = 8;
            this.btSync.Text = "同步";
            this.btSync.UseVisualStyleBackColor = true;
            this.btSync.Click += new System.EventHandler(this.btSync_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "文檔列表";
            // 
            // tbConStr1
            // 
            this.tbConStr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConStr1.Location = new System.Drawing.Point(63, 8);
            this.tbConStr1.Name = "tbConStr1";
            this.tbConStr1.Size = new System.Drawing.Size(535, 21);
            this.tbConStr1.TabIndex = 10;
            // 
            // tbConStr2
            // 
            this.tbConStr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConStr2.Location = new System.Drawing.Point(63, 38);
            this.tbConStr2.Name = "tbConStr2";
            this.tbConStr2.Size = new System.Drawing.Size(535, 21);
            this.tbConStr2.TabIndex = 11;
            // 
            // tbDBName1
            // 
            this.tbDBName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDBName1.Location = new System.Drawing.Point(664, 8);
            this.tbDBName1.Name = "tbDBName1";
            this.tbDBName1.Size = new System.Drawing.Size(94, 21);
            this.tbDBName1.TabIndex = 12;
            // 
            // tbDBName2
            // 
            this.tbDBName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDBName2.Location = new System.Drawing.Point(664, 38);
            this.tbDBName2.Name = "tbDBName2";
            this.tbDBName2.Size = new System.Drawing.Size(94, 21);
            this.tbDBName2.TabIndex = 13;
            // 
            // tbLogs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbLogs, 5);
            this.tbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogs.Location = new System.Drawing.Point(3, 368);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.ReadOnly = true;
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogs.Size = new System.Drawing.Size(855, 175);
            this.tbLogs.TabIndex = 16;
            // 
            // btSelectAll
            // 
            this.btSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSelectAll.Location = new System.Drawing.Point(604, 73);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(54, 24);
            this.btSelectAll.TabIndex = 14;
            this.btSelectAll.Text = "全選";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btDisselectAll
            // 
            this.btDisselectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDisselectAll.Location = new System.Drawing.Point(604, 103);
            this.btDisselectAll.Name = "btDisselectAll";
            this.btDisselectAll.Size = new System.Drawing.Size(54, 24);
            this.btDisselectAll.TabIndex = 15;
            this.btDisselectAll.Text = "全取";
            this.btDisselectAll.UseVisualStyleBackColor = true;
            this.btDisselectAll.Click += new System.EventHandler(this.btDisselectAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo同步工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTest1;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btTest2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btReadDocs;
        private System.Windows.Forms.Button btSync;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConStr1;
        private System.Windows.Forms.TextBox tbConStr2;
        private System.Windows.Forms.TextBox tbDBName1;
        private System.Windows.Forms.TextBox tbDBName2;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDisselectAll;
        public System.Windows.Forms.TextBox tbLogs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDocumentName;
    }
}