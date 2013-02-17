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

namespace WebKitBrowser.UI
{
    [ProgId("WebKitBrowser.UI.BrowserForm"), ComVisible(true)]
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
            //UID = "{6CCD0EE9-20DB-4636-9149-665A958D8A9A}";
            UID = Guid.NewGuid().ToString();
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
            webControl1.GoToHome();
        }

        private void navSubmit_Click(object sender, EventArgs e)
        {
            webControl1.Source = addressBox.URL;
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

        private void addressBox_Navigate(object sender, Awesomium.Core.UrlEventArgs e)
        {
            webControl1.Source = addressBox.URL;
        }
    }
}
