using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace AutomationFirstProject
{
    public partial class frmMain : Form
    {        
        HtmlWeb htmlWeb = new HtmlWeb();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetContent_Click(object sender, EventArgs e)
        {
            var doc = htmlWeb.Load(txtUri.Text);

            var haber = new List<Haberler>();

            HtmlNodeCollection hblInbox = doc.DocumentNode.SelectNodes("//div[@class='hblnBox']");

            foreach (var inbox in hblInbox)
            {
                try
                {
                    string haberZamani = inbox.SelectSingleNode("./div[@class='hblnTime']").InnerText;
                    string haberResim = inbox.SelectSingleNode("./div[@class='hblnImage']/a/img").Attributes["src"].Value;
                    string haberTitle = inbox.SelectSingleNode(".//a[@class='hblnTitle']").InnerText;
                    string haberUri = inbox.SelectSingleNode(".//a[@class='hblnTitle']").Attributes["href"].Value;
                    string haberAciklama = inbox.SelectSingleNode("./div[@class='hblnContent']/p").InnerText;

                    haber.Add(new Haberler()
                    {
                        Aciklama = haberAciklama,
                        Baslik = haberTitle,
                        PictureUri = haberResim,
                        Time = haberZamani,
                        Uri = haberUri
                    });

                    lstNews.Items.Add(haberTitle);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.StackTrace);
                }
            }

            MessageBox.Show($"Haberler çekildi.Toplam haber sayısı {haber.Count}");
        }
    }
}
