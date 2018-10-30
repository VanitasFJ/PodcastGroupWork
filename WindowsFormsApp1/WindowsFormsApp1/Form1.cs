using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			InitializeComponent();
			this.Text = "Podcast";
            UppdateraKatCombo();
            LaddaKategori();

        }

        private void add(String name, String frek, String category, String url) {
            String[] row = {name, frek, category, url };

            ListViewItem item = new ListViewItem(row);

            lvPodLista.Items.Add(item);

            //Uppdatera rad
            //lvPodLista.SelectedItems[0].SubItems[0(vilken kolumn)].Text = columnName.Text;

        }

        private void delete() {
            if(MessageBox.Show("Är du säker?","Ta Bort", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lvPodLista.Items.RemoveAt(lvPodLista.SelectedIndices[0]);

            }

        }

        private void LaddaKategori()
        {

            XElement element = XElement.Load("savefile.xml");
            foreach (XElement item in element.Elements("Item"))
            {
                lbKategori.Items.Add(item.Value);
                // comboKategori.Items.Add(item.Value);
            }
        }

        private void UppdateraKatCombo()
        {
            cbKategori.Items.Clear();
            XElement element = XElement.Load("savefile.xml");
            foreach (XElement item in element.Elements("Item"))

                cbKategori.Items.Add(item.Value);

        }

        String[,] rssData = null;

        private String[,] getRssData(String channel) {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new String[1000000, 3];

            for (int i = 0; i < rssItems.Count; i++) {
                System.Xml.XmlNode rssNode;

                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else {
                    tempRssData[i, 0] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;
                }
                else {
                    tempRssData[i, 1] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }


            }
            return tempRssData;
        }

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {

            add(tbNamn.Text, cbFrekvens.Text, cbKategori.Text, tbUrl.Text);

        }

        private void cbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                tbAvsnittsInfo.Text = rssData[cbAvsnitt.SelectedIndex, 1];
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                llLankTill.Text = "Gå till länk: " + rssData[cbAvsnitt.SelectedIndex, 0];
        }

        private void llLankTill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssData[cbAvsnitt.SelectedIndex, 2]);
        }

        private void lvPodLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAvsnitt.Items.Clear();
            rssData = getRssData(lvPodLista.SelectedItems[0].SubItems[3].Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    cbAvsnitt.Items.Add(rssData[i, 0]);
                }
                cbAvsnitt.SelectedIndex = 0;
            }
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            if (tbKategori.Text != "")
            {
                lbKategori.Items.Add(this.tbKategori.Text);
                this.tbKategori.Focus();
                this.tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Skriv in ett namn för att kunna addera ny Kategori.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbKategori.Focus();
            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (this.lbKategori.SelectedIndex >= 0)
            {
                this.lbKategori.Items.RemoveAt(this.lbKategori.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Välj kategori för att ta bort", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbKategori.Focus();
            }
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            
                XmlTextWriter xwriter = new XmlTextWriter("savefile.xml", Encoding.Unicode);
                xwriter.WriteStartDocument();
                xwriter.WriteStartElement("XMLFILE");
                xwriter.WriteStartElement("Title");
                xwriter.WriteString(tbKategori.Text);
                xwriter.WriteEndElement();
                foreach (String item in lbKategori.Items)

                {
                    xwriter.WriteStartElement("Item");
                    xwriter.WriteString(item);
                    xwriter.WriteEndElement();
                }
                xwriter.WriteEndElement();
                xwriter.WriteEndDocument();

                xwriter.Close();
            UppdateraKatCombo();


        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            XmlTextWriter xwriter = new XmlTextWriter("feedfile.xml", Encoding.Unicode);
            xwriter.WriteStartDocument();
            xwriter.WriteStartElement("XMLFILE");
            xwriter.WriteStartElement("Title");
            xwriter.WriteString(tbKategori.Text);
            xwriter.WriteEndElement();
            foreach (String item in lvPodLista.Items)

            {
                xwriter.WriteStartElement("Item");
                xwriter.WriteString(item);
                xwriter.WriteEndElement();
            }
            xwriter.WriteEndElement();
            xwriter.WriteEndDocument();

            xwriter.Close();
        }
    }
}
