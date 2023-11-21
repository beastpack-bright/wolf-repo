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

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;

            
            HtmlElement h1Element = webBrowser.Document.GetElementsByTagName("h1")[0];
            h1Element.InnerText = "My UFO Page";

            
            HtmlElement h2Element1 = webBrowser.Document.GetElementsByTagName("h2")[0];
            h2Element1.InnerText = "My UFO Info";

            
            HtmlElement h2Element2 = webBrowser.Document.GetElementsByTagName("h2")[1];
            h2Element2.InnerText = "My UFO Pictures";

            
            HtmlElement h2Element3 = webBrowser.Document.GetElementsByTagName("h2")[2];
            h2Element3.InnerText = "";

            
            HtmlElement bodyElement = webBrowser.Document.Body;
            bodyElement.Style = "font-family: sans-serif; color: #FF0000"; // reddish color

            
            HtmlElement firstParagraph = webBrowser.Document.GetElementsByTagName("p")[0];
            firstParagraph.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>Nuforc.org</a>";
            firstParagraph.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

            
            HtmlElement secondParagraph = webBrowser.Document.GetElementsByTagName("p")[1];
            secondParagraph.InnerText = "";

            
            HtmlElement thirdParagraph = webBrowser.Document.GetElementsByTagName("p")[2];
            HtmlElement imgElement = webBrowser.Document.CreateElement("img");
            imgElement.SetAttribute("src", "https://fthmb.tqn.com/BTZrHgdClL8Bjid8EKEF1E8U5qM=/768x0/filters:no_upscale()/ufo-over-a-city-88830821-59f0d51803f4020010a3c2ee.jpg");
            thirdParagraph.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, imgElement);

            
            HtmlElement footerElement = webBrowser.Document.CreateElement("footer");
            footerElement.InnerHtml = "&copy; " + DateTime.Now.Year + " Elizabeth Sanabria";
            webBrowser.Document.Body.AppendChild(footerElement);
        }

    }
}
