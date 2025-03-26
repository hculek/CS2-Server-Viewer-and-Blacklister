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
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            geoCoordinatesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverViewerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource2).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GetServerListBtn
            // 
            GetServerListBtn.Location = new Point(9, 14);
            GetServerListBtn.Name = "GetServerListBtn";
            GetServerListBtn.Size = new Size(99, 23);
            GetServerListBtn.TabIndex = 0;
            GetServerListBtn.Text = "Get Server List";
            GetServerListBtn.UseVisualStyleBackColor = true;
            GetServerListBtn.Click += GetServerListBtn_Click;
            // 
            // GenerateBlacklistBtn
            // 
            GenerateBlacklistBtn.Location = new Point(141, 14);
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
            serverViewerDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, geoCoordinatesDataGridViewTextBoxColumn, dataGridViewTextBoxColumn7, dataGridViewCheckBoxColumn2 });
            serverViewerDataGrid.DataSource = serverModelBindingSource2;
            serverViewerDataGrid.Location = new Point(12, 58);
            serverViewerDataGrid.Name = "serverViewerDataGrid";
            serverViewerDataGrid.RowHeadersVisible = false;
            serverViewerDataGrid.Size = new Size(557, 348);
            serverViewerDataGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "#";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn5.Width = 39;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "Desc";
            dataGridViewTextBoxColumn6.HeaderText = "Description";
            dataGridViewTextBoxColumn6.MinimumWidth = 300;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn6.Width = 300;
            // 
            // geoCoordinatesDataGridViewTextBoxColumn
            // 
            geoCoordinatesDataGridViewTextBoxColumn.DataPropertyName = "GeoCoordinates";
            geoCoordinatesDataGridViewTextBoxColumn.HeaderText = "GeoCoordinates";
            geoCoordinatesDataGridViewTextBoxColumn.Name = "geoCoordinatesDataGridViewTextBoxColumn";
            geoCoordinatesDataGridViewTextBoxColumn.ReadOnly = true;
            geoCoordinatesDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "Region";
            dataGridViewTextBoxColumn7.HeaderText = "Region";
            dataGridViewTextBoxColumn7.MinimumWidth = 80;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCheckBoxColumn2.DataPropertyName = "Blacklisted";
            dataGridViewCheckBoxColumn2.HeaderText = "Blacklisted";
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            dataGridViewCheckBoxColumn2.Width = 69;
            // 
            // serverModelBindingSource2
            // 
            serverModelBindingSource2.DataSource = typeof(Models.ServerModel);
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(590, 87);
            ipTextBox.Multiline = true;
            ipTextBox.Name = "ipTextBox";
            ipTextBox.ReadOnly = true;
            ipTextBox.Size = new Size(243, 114);
            ipTextBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(590, 246);
            portTextBox.Multiline = true;
            portTextBox.Name = "portTextBox";
            portTextBox.ReadOnly = true;
            portTextBox.Size = new Size(243, 75);
            portTextBox.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(848, 22);
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
            infoUrlLabel.Location = new Point(590, 375);
            infoUrlLabel.Name = "infoUrlLabel";
            infoUrlLabel.Size = new Size(243, 20);
            infoUrlLabel.TabIndex = 9;
            infoUrlLabel.TabStop = true;
            infoUrlLabel.Text = "infoUrlLabel";
            infoUrlLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            infoLabel.Location = new Point(590, 335);
            infoLabel.Name = "infoLabel";
            infoLabel.RightToLeft = RightToLeft.No;
            infoLabel.Size = new Size(243, 20);
            infoLabel.TabIndex = 10;
            infoLabel.Text = "infoLabel";
            infoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // verLabel
            // 
            verLabel.Location = new Point(590, 355);
            verLabel.Name = "verLabel";
            verLabel.Size = new Size(243, 20);
            verLabel.TabIndex = 11;
            verLabel.Text = "verLabel";
            verLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // copyIpsBtn
            // 
            copyIpsBtn.Location = new Point(590, 58);
            copyIpsBtn.Name = "copyIpsBtn";
            copyIpsBtn.Size = new Size(86, 23);
            copyIpsBtn.TabIndex = 12;
            copyIpsBtn.Text = "Copy ips:";
            copyIpsBtn.UseVisualStyleBackColor = true;
            copyIpsBtn.Click += copyIpsBtn_Click;
            // 
            // copyPortsBtn
            // 
            copyPortsBtn.Location = new Point(590, 217);
            copyPortsBtn.Name = "copyPortsBtn";
            copyPortsBtn.Size = new Size(86, 23);
            copyPortsBtn.TabIndex = 13;
            copyPortsBtn.Text = "Copy ports:";
            copyPortsBtn.UseVisualStyleBackColor = true;
            copyPortsBtn.Click += copyPortsBtn_Click;
            // 
            // delimiterTextBox
            // 
            delimiterTextBox.Location = new Point(322, 14);
            delimiterTextBox.Name = "delimiterTextBox";
            delimiterTextBox.Size = new Size(34, 23);
            delimiterTextBox.TabIndex = 14;
            delimiterTextBox.Text = ",";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 15;
            label1.Text = "Delimiter:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 448);
            Controls.Add(label1);
            Controls.Add(delimiterTextBox);
            Controls.Add(copyPortsBtn);
            Controls.Add(copyIpsBtn);
            Controls.Add(verLabel);
            Controls.Add(infoLabel);
            Controls.Add(infoUrlLabel);
            Controls.Add(statusStrip1);
            Controls.Add(portTextBox);
            Controls.Add(ipTextBox);
            Controls.Add(serverViewerDataGrid);
            Controls.Add(GenerateBlacklistBtn);
            Controls.Add(GetServerListBtn);
            Name = "Form1";
            Text = "CS2 Server Viewer & Blacklisting";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverViewerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverModelBindingSource2).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn geoCoordinatesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private LinkLabel infoUrlLabel;
        private Label infoLabel;
        private Label verLabel;
        private Button copyIpsBtn;
        private Button copyPortsBtn;
        private TextBox delimiterTextBox;
        private Label label1;
    }
}
