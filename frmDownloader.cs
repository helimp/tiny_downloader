using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Downloader
{
    public partial class frmDownloader : Form
    {
        INIReader iniReader;
        UrlTokenList lstUrlToken = new UrlTokenList();

        public frmDownloader()
        {
            InitializeComponent();

            Reload();
        }

        private void Reload()
        {
            if (iniReader == null)
            {
                String curDir = Environment.CurrentDirectory;
                String iniPath = Path.Combine(curDir, "downloader.ini");
                iniReader = new INIReader(iniPath, "FILES");
            }

            lstUrls.Items.Clear();
            lstUrlToken.Clear();

            for (int i = 1; i < 100; i++)
            {
                string urlToken = iniReader.IniReadValue(i.ToString());

                if (string.IsNullOrEmpty(urlToken))
                    break;

                AddToList(urlToken);
            }

            SelectAll();
        }

        private void AddToList(string urlToken)
        {
            UrlToken oUrlToken = UrlToken.Parse(urlToken);
            if (oUrlToken != null)
            {
                lstUrlToken.Add(oUrlToken);
                lstUrls.Items.Add(oUrlToken);
            }
        }

        private void SelectAll()
        {
            for (int i = 0; i < lstUrls.Items.Count; i++)
            {
                lstUrls.SetItemChecked(i, true);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            String curDir = Environment.CurrentDirectory;
            Uri uri;
            String filePath;

            CheckedListBox.CheckedItemCollection lstItems = lstUrls.CheckedItems;

            btnDownload.Text = "Please Wait...";
            this.Enabled = false;

            foreach (object item in lstItems)
            {
                uri = new Uri(((UrlToken)item).Url);

                filePath = ((UrlToken)item).FileName;

                if (!string.IsNullOrEmpty(filePath))
                {
                    filePath = Path.Combine(curDir, filePath);

                    // Create a new WebClient instance.
                    WebClient myWebClient = new WebClient();

                    // Download the Web resource and save it into the current filesystem folder.
                    myWebClient.DownloadFile(((UrlToken)item).Url, filePath);
                }
            }

            this.Enabled = true;
            btnDownload.Text = "Download";
        }
    }
}
