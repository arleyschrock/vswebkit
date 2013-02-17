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

            BindEvents();
        }

        private void BindEvents()
        {
            var src = typeof(PictureBox).GetEvents();
            var tgt = typeof(ImageButton).GetEvents();
            foreach (var ev in src)
            {
                var target = tgt.FirstOrDefault(x => x.Name == ev.Name);
                if (target == null)
                {
                    continue;
                }
                try
                {
                    target.AddEventHandler(this,
                        ev.RaiseMethod.CreateDelegate(ev.DeclaringType));
                }
                catch { }
            }
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
    }
}
