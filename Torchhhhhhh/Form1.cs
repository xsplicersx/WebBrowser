using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torchhhhhhh
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewTab()
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            metroTabControl1.Controls.Add(tab);
            metroTabControl1.SelectTab(metroTabControl1.TabCount - 1);
            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");
            metroTextBox1.Text = "https://www.google.com";
            browser.DocumentCompleted += browser_DocumentCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                metroTabControl1.SelectedTab.Text = browser.DocumentTitle;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoBack)
                    browser.GoBack();
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                    browser.GoForward();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                browser.Navigate(metroTextBox1.Text);
        }


       /// <summary>
       /// this is the core search function 
       /// </summary>
        private void NavigateTopage()
        {
            
        }

        /// <summary>
        /// this will fire when a key is pushed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {

            }
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                browser.Navigate("https://www.google.com");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                browser.Refresh();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTabControl1.TabPages.RemoveAt(metroTabControl1.SelectedIndex);
        }
    }
}
