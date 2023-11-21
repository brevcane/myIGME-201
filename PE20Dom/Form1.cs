using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

            

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser1 = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            HtmlDocument doc = webBrowser1.Document;

            var h1 = doc.GetElementsByTagName("h1")[0];
            h1.InnerText = "My UFO Page";

            var h2_1 = doc.GetElementsByTagName("h2")[0];
            h2_1.InnerText = "My UFO Info";


            var h2_2 = doc.GetElementsByTagName("h2")[1];
            h2_2.InnerText = "My UFO Pictures";

            var h2_3 = doc.GetElementsByTagName("h2")[2];
            h2_3.InnerText = "";


            var body = doc.Body;
            body.Style = "font-family: sans-serif; color: #FF0000";


            var firstParagraph = doc.GetElementsByTagName("p")[0];
            firstParagraph.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>http://www.nuforc.org</a>";
            firstParagraph.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";


            var secondParagraph = doc.GetElementsByTagName("p")[1];
            secondParagraph.InnerText = "";


            var thirdParagraph = doc.GetElementsByTagName("p")[2];
            var imgElement = doc.CreateElement("img");
            imgElement.SetAttribute("src", "https://th.bing.com/th/id/OIP.WsYixyAO2T8DrAQQ7NLMXwHaEc?w=298&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7");
            imgElement.SetAttribute("alt", "UFO Image");
            thirdParagraph.AppendChild(imgElement);


            var footer = doc.CreateElement("footer");
            footer.InnerHtml = "&copy; " + 2023 + " Brevin";
            doc.Body.AppendChild(footer);
        }
    }
}
