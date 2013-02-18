using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Web;
using Awesomium.Core;

namespace WebKitBrowser.UI
{
    [ProgId("WebKitBrowser.UI.BrowserForm"), ComVisible(true)]
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            WebCoreInit();

            InitializeComponent();

            UID = Guid.NewGuid().ToString();

            webControl1.DocumentReady += webControl1_DocumentReady;
            webControl1.BeginNavigation += webControl1_BeginNavigation;
            webControl1.TitleChanged += webControl1_TitleChanged;

            GoHome();
        }

        private void WebCoreInit()
        {
            if (WebCore.IsRunning)
            {
                return;
            }
            var config = WebConfig.Default;
            config.HomeURL = new Uri(Properties.Settings.Default.HomePage);
            WebCore.Initialize(config);
            WebPreferences prefs = WebPreferences.Default;
            prefs.CanScriptsOpenWindows = true;
            prefs.CanScriptsAccessClipboard = true;
            prefs.AllowInsecureContent = true;
            prefs.EnableGPUAcceleration = true;
            prefs.WebAudio = true;
            prefs.SmoothScrolling = true;
            prefs.WebGL = true;
            prefs.UniversalAccessFromFileURL = true;
            prefs.FileAccessFromFileURL = true;
            prefs.EnableGPUAcceleration = true;
        }

        private void GoHome()
        {
            Uri home;
            if (Uri.TryCreate(Properties.Settings.Default.HomePage, UriKind.Absolute, out home))
            {
                webControl1.Source = home;
            }
        }

        void webControl1_TitleChanged(object sender, Awesomium.Core.TitleChangedEventArgs e)
        {
            Text = e.Title;
        }

        void webControl1_BeginNavigation(object sender, Awesomium.Core.UrlEventArgs e)
        {
            addressBox.Text = e.Url.ToString();
        }

        void webControl1_DocumentReady(object sender, Awesomium.Core.UrlEventArgs e)
        {
            addressBox.Text = e.Url.ToString();
        }

        private void navPrevious_Click(object sender, EventArgs e)
        {
            webControl1.GoToHistoryOffset(-1);
        }

        private void navForward_Click(object sender, EventArgs e)
        {
            webControl1.GoToHistoryOffset(1);
        }

        private void navRefresh_Click(object sender, EventArgs e)
        {
            webControl1.Refresh();
        }

        private void navHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void navSubmit_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        public string UID
        {
            get;
            protected set;
        }

        public string ProgId
        {
            get
            {
                return "WebKitBrowser.UI.BrowserForm";
            }
        }

        private void Navigate()
        {
            try
            {
                webControl1.Source = new Uri(addressBox.Text);
            }
            catch
            {
                DoSearch(addressBox.Text);
            }
        }

        private void DoSearch(string p)
        {
            var url = string.Format(
                Properties.Settings.Default.SearchUrlPattern,
                HttpUtility.UrlEncode(p));
            addressBox.Text = url;
            webControl1.Source = new Uri(url);
        }

        private void addressBox_Validating(object sender, CancelEventArgs e)
        {
            var text = addressBox.Text;
            Uri uri;
            e.Cancel = !Uri.TryCreate(text, UriKind.Absolute, out uri);
        }

        private void addressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate();
            }
        }
    }
}
