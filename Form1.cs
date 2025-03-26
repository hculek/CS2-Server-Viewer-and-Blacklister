using CS_Server_Viewer.Components;
using CS_Server_Viewer.Models;
using System.ComponentModel;

namespace CS_Server_Viewer
{
    public partial class Form1 : Form
    {
        private List<ServerModel> servers = new List<ServerModel>();
        private (string, string) blacklist = new(string.Empty, string.Empty);

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetServerListBtn_Click(object sender, EventArgs e)
        {
            SetStatus(StatusModel.JobInProgress);

            ServerGetter sg = new ServerGetter();

            servers = new List<ServerModel>();

            try
            {
                servers = await sg.GetServers();

                if (servers.Any())
                {
                    serverViewerDataGrid.DataSource = servers.OrderBy(c => c.Region).ToList(); ;

                    SetStatus(StatusModel.JobDone);
                }
            }
            catch (Exception ex)
            {
                SetStatus(string.Format(StatusModel.ErrorTemplate, ex.Message));
            }
        }

        private async void GenerateBlacklistBtn_Click(object sender, EventArgs e)
        {
            SetStatus(StatusModel.JobInProgress);

            OutputHelper oh = new OutputHelper();

            try
            {
                if (!servers.Any())
                {
                    SetStatus(StatusModel.ErrorServersEmpty);
                    return;
                }
                else if (servers.Where(s => s.Blacklisted == true).Select(x => x).Any())
                {
                    blacklist = new(string.Empty, string.Empty);

                    blacklist = await oh.GetBlacklist(delimiterTextBox.Text, servers);

                    ipTextBox.Text = blacklist.Item1;

                    portTextBox.Text = blacklist.Item2;

                    SetStatus(StatusModel.JobDone);
                }
                else
                {
                    SetStatus(StatusModel.ErrorNothingSelected);
                }
            }
            catch (Exception ex)
            {
                SetStatus(string.Format(StatusModel.ErrorTemplate, ex.Message));
            }


        }

        private void serverViewerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (serverViewerDataGrid.Columns[e.ColumnIndex].DataPropertyName == "Blacklisted")
            {
                bool value = (bool)serverViewerDataGrid[e.ColumnIndex, e.RowIndex].Value;

                var server = (ServerModel)serverViewerDataGrid.Rows[e.RowIndex].DataBoundItem;

                server.Blacklisted = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = StatusModel.ProgramTitle;
            infoLabel.Text = StatusModel.Author;
            verLabel.Text = StatusModel.Licence;
            infoUrlLabel.Text = StatusModel.GitUrl;

        }

        private void SetStatus(string status)
        {
            if (status.Contains(StatusModel.ErrorMsg))
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
            }

            toolStripStatusLabel1.Text = status;
        }

        private void copyIpsBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(blacklist.Item1))
            {
                Clipboard.SetText(blacklist.Item1);
            }
            else
            {
                SetStatus(StatusModel.ErrorBlacklistEmpty);
            }
        }

        private void copyPortsBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(blacklist.Item2))
            {
                Clipboard.SetText(blacklist.Item2);
            }
            else
            {
                SetStatus(StatusModel.ErrorBlacklistEmpty);
            }
        }
    }
}
