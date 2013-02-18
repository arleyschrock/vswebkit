using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebKitBrowser.UI
{
    public partial class ImageButton : UserControl
    {
        public ImageButton()
        {
            InitializeComponent();
        }

        [Browsable(true), DisplayName("Background Image")]
        public new Image BackgroundImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
