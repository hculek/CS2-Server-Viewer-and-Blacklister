namespace CS_Server_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GetServerListBtn = new Button();
            GenerateBlacklistBtn = new Button();
            serverModelBindingSource1 = new BindingSource(components);
            serverModelBindingSource = new BindingSource(components);
            serverViewerDataGrid = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            geoCoordinatesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RegionColumn = new DataGridViewTextBoxColumn();
            BlacklistedColumn = new DataGridViewCheckBoxColumn();
            serverModelBindingSource2 = new BindingSource(components);
            ipTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            portTextBox = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            infoUrlLabel = new LinkLabel();
            infoLabel = new Label();
            verLabel = new Label();
            copyIpsBtn = new Button();
            copyPortsBtn = new Button();
            delimiterTextBox = new TextBox();
            label1 = new Label();
            RegionsCheckedListBox = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverViewerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource2).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GetServerListBtn
            // 
            GetServerListBtn.Location = new Point(6, 22);
            GetServerListBtn.Name = "GetServerListBtn";
            GetServerListBtn.Size = new Size(99, 23);
            GetServerListBtn.TabIndex = 0;
            GetServerListBtn.Text = "Get Server List";
            GetServerListBtn.UseVisualStyleBackColor = true;
            GetServerListBtn.Click += GetServerListBtn_Click;
            // 
            // GenerateBlacklistBtn
            // 
            GenerateBlacklistBtn.Location = new Point(6, 22);
            GenerateBlacklistBtn.Name = "GenerateBlacklistBtn";
            GenerateBlacklistBtn.Size = new Size(111, 23);
            GenerateBlacklistBtn.TabIndex = 1;
            GenerateBlacklistBtn.Text = "Generate Blacklist";
            GenerateBlacklistBtn.UseVisualStyleBackColor = true;
            GenerateBlacklistBtn.Click += GenerateBlacklistBtn_Click;
            // 
            // serverViewerDataGrid
            // 
            serverViewerDataGrid.AllowUserToAddRows = false;
            serverViewerDataGrid.AllowUserToDeleteRows = false;
            serverViewerDataGrid.AllowUserToOrderColumns = true;
            serverViewerDataGrid.AllowUserToResizeColumns = false;
            serverViewerDataGrid.AllowUserToResizeRows = false;
            serverViewerDataGrid.AutoGenerateColumns = false;
            serverViewerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serverViewerDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdColumn, DescriptionColumn, geoCoordinatesDataGridViewTextBoxColumn, RegionColumn, BlacklistedColumn });
            serverViewerDataGrid.DataSource = serverModelBindingSource2;
            serverViewerDataGrid.Location = new Point(6, 51);
            serverViewerDataGrid.Name = "serverViewerDataGrid";
            serverViewerDataGrid.RowHeadersVisible = false;
            serverViewerDataGrid.Size = new Size(557, 348);
            serverViewerDataGrid.TabIndex = 2;
            serverViewerDataGrid.CellFormatting += serverViewerDataGrid_CellFormating;
            // 
            // IdColumn
            // 
            IdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "#";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Resizable = DataGridViewTriState.False;
            IdColumn.Width = 39;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DescriptionColumn.DataPropertyName = "Desc";
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.MinimumWidth = 310;
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            DescriptionColumn.Resizable = DataGridViewTriState.False;
            DescriptionColumn.Width = 310;
            // 
            // geoCoordinatesDataGridViewTextBoxColumn
            // 
            geoCoordinatesDataGridViewTextBoxColumn.DataPropertyName = "GeoCoordinates";
            geoCoordinatesDataGridViewTextBoxColumn.HeaderText = "GeoCoordinates";
            geoCoordinatesDataGridViewTextBoxColumn.Name = "geoCoordinatesDataGridViewTextBoxColumn";
            geoCoordinatesDataGridViewTextBoxColumn.ReadOnly = true;
            geoCoordinatesDataGridViewTextBoxColumn.Visible = false;
            // 
            // RegionColumn
            // 
            RegionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RegionColumn.DataPropertyName = "Region";
            RegionColumn.HeaderText = "Region";
            RegionColumn.MinimumWidth = 115;
            RegionColumn.Name = "RegionColumn";
            RegionColumn.ReadOnly = true;
            RegionColumn.Resizable = DataGridViewTriState.False;
            RegionColumn.Width = 115;
            // 
            // BlacklistedColumn
            // 
            BlacklistedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            BlacklistedColumn.DataPropertyName = "Blacklisted";
            BlacklistedColumn.HeaderText = "Blacklisted";
            BlacklistedColumn.Name = "BlacklistedColumn";
            BlacklistedColumn.Width = 69;
            // 
            // serverModelBindingSource2
            // 
            serverModelBindingSource2.DataSource = typeof(Models.ServerModel);
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(6, 51);
            ipTextBox.Multiline = true;
            ipTextBox.Name = "ipTextBox";
            ipTextBox.ReadOnly = true;
            ipTextBox.Size = new Size(205, 111);
            ipTextBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(219, 51);
            portTextBox.Multiline = true;
            portTextBox.Name = "portTextBox";
            portTextBox.ReadOnly = true;
            portTextBox.Size = new Size(205, 111);
            portTextBox.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(755, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // infoUrlLabel
            // 
            infoUrlLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            infoUrlLabel.Location = new Point(572, 549);
            infoUrlLabel.Name = "infoUrlLabel";
            infoUrlLabel.Size = new Size(168, 20);
            infoUrlLabel.TabIndex = 9;
            infoUrlLabel.TabStop = true;
            infoUrlLabel.Text = "infoUrlLabel";
            infoUrlLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            infoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            infoLabel.Location = new Point(572, 509);
            infoLabel.Name = "infoLabel";
            infoLabel.RightToLeft = RightToLeft.No;
            infoLabel.Size = new Size(168, 20);
            infoLabel.TabIndex = 10;
            infoLabel.Text = "infoLabel";
            infoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // verLabel
            // 
            verLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            verLabel.Location = new Point(572, 529);
            verLabel.Name = "verLabel";
            verLabel.Size = new Size(168, 20);
            verLabel.TabIndex = 11;
            verLabel.Text = "verLabel";
            verLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // copyIpsBtn
            // 
            copyIpsBtn.Location = new Point(6, 22);
            copyIpsBtn.Name = "copyIpsBtn";
            copyIpsBtn.Size = new Size(86, 23);
            copyIpsBtn.TabIndex = 12;
            copyIpsBtn.Text = "Copy ips:";
            copyIpsBtn.UseVisualStyleBackColor = true;
            copyIpsBtn.Click += copyIpsBtn_Click;
            // 
            // copyPortsBtn
            // 
            copyPortsBtn.Location = new Point(219, 22);
            copyPortsBtn.Name = "copyPortsBtn";
            copyPortsBtn.Size = new Size(86, 23);
            copyPortsBtn.TabIndex = 13;
            copyPortsBtn.Text = "Copy ports:";
            copyPortsBtn.UseVisualStyleBackColor = true;
            copyPortsBtn.Click += copyPortsBtn_Click;
            // 
            // delimiterTextBox
            // 
            delimiterTextBox.Location = new Point(70, 64);
            delimiterTextBox.Name = "delimiterTextBox";
            delimiterTextBox.Size = new Size(44, 23);
            delimiterTextBox.TabIndex = 14;
            delimiterTextBox.Text = ",";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 67);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 15;
            label1.Text = "Delimiter:";
            // 
            // RegionsCheckedListBox
            // 
            RegionsCheckedListBox.Enabled = false;
            RegionsCheckedListBox.FormattingEnabled = true;
            RegionsCheckedListBox.Location = new Point(569, 51);
            RegionsCheckedListBox.MinimumSize = new Size(150, 348);
            RegionsCheckedListBox.Name = "RegionsCheckedListBox";
            RegionsCheckedListBox.Size = new Size(164, 346);
            RegionsCheckedListBox.TabIndex = 16;
            RegionsCheckedListBox.ItemCheck += RegionsCheckedListBox_ItemCheck;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RegionsCheckedListBox);
            groupBox1.Controls.Add(serverViewerDataGrid);
            groupBox1.Controls.Add(GetServerListBtn);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 406);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server List";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GenerateBlacklistBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(delimiterTextBox);
            groupBox2.Location = new Point(3, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(127, 168);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Blacklist Tools";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(copyIpsBtn);
            groupBox3.Controls.Add(ipTextBox);
            groupBox3.Controls.Add(copyPortsBtn);
            groupBox3.Controls.Add(portTextBox);
            groupBox3.Location = new Point(136, 418);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 168);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Blacklist";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 611);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(verLabel);
            Controls.Add(infoLabel);
            Controls.Add(infoUrlLabel);
            Controls.Add(statusStrip1);
            MaximumSize = new Size(771, 650);
            MinimumSize = new Size(771, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CS2 Server Viewer & Blacklisting";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverViewerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource2).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetServerListBtn;
        private Button GenerateBlacklistBtn;
        private BindingSource serverModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn geoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn blacklistedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private BindingSource serverModelBindingSource1;
        private DataGridView serverViewerDataGrid;
        private BindingSource serverModelBindingSource2;
        private TextBox ipTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox portTextBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private LinkLabel infoUrlLabel;
        private Label infoLabel;
        private Label verLabel;
        private Button copyIpsBtn;
        private Button copyPortsBtn;
        private TextBox delimiterTextBox;
        private Label label1;
        private CheckedListBox RegionsCheckedListBox;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn geoCoordinatesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RegionColumn;
        private DataGridViewCheckBoxColumn BlacklistedColumn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
