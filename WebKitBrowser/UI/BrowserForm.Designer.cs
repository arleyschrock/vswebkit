namespace WebKitBrowser.UI
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addressBox = new Awesomium.Windows.Forms.AddressBox();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl();
            this.navHome = new WebKitBrowser.UI.ImageButton();
            this.navRefresh = new WebKitBrowser.UI.ImageButton();
            this.navForward = new WebKitBrowser.UI.ImageButton();
            this.navPrevious = new WebKitBrowser.UI.ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navSubmit = new WebKitBrowser.UI.ImageButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.navHome);
            this.panel1.Controls.Add(this.navRefresh);
            this.panel1.Controls.Add(this.navForward);
            this.panel1.Controls.Add(this.navPrevious);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(972, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addressBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(94, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel3.Size = new System.Drawing.Size(712, 24);
            this.panel3.TabIndex = 5;
            // 
            // addressBox
            // 
            this.addressBox.AcceptsReturn = true;
            this.addressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressBox.Location = new System.Drawing.Point(0, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(712, 20);
            this.addressBox.TabIndex = 0;
            this.addressBox.URL = null;
            this.addressBox.WebControl = this.webControl1;
            this.addressBox.Navigate += new System.EventHandler<Awesomium.Core.UrlEventArgs>(this.addressBox_Navigate);
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 36);
            this.webControl1.Name = "webControl1";
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.webControl1.Size = new System.Drawing.Size(972, 548);
            this.webControl1.TabIndex = 1;
            // 
            // navHome
            // 
            this.navHome.BackColor = System.Drawing.Color.Transparent;
            this.navHome.BackgroundImage = global::WebKitBrowser.Properties.Resources.Home;
            this.navHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.navHome.Location = new System.Drawing.Point(72, 6);
            this.navHome.Name = "navHome";
            this.navHome.Padding = new System.Windows.Forms.Padding(3);
            this.navHome.Size = new System.Drawing.Size(22, 24);
            this.navHome.TabIndex = 4;
            this.navHome.Click += new System.EventHandler(this.navHome_Click);
            // 
            // navRefresh
            // 
            this.navRefresh.BackColor = System.Drawing.Color.Transparent;
            this.navRefresh.BackgroundImage = global::WebKitBrowser.Properties.Resources.Refresh;
            this.navRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.navRefresh.Location = new System.Drawing.Point(50, 6);
            this.navRefresh.Name = "navRefresh";
            this.navRefresh.Padding = new System.Windows.Forms.Padding(3);
            this.navRefresh.Size = new System.Drawing.Size(22, 24);
            this.navRefresh.TabIndex = 3;
            this.navRefresh.Click += new System.EventHandler(this.navRefresh_Click);
            // 
            // navForward
            // 
            this.navForward.BackColor = System.Drawing.Color.Transparent;
            this.navForward.BackgroundImage = global::WebKitBrowser.Properties.Resources.Next;
            this.navForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navForward.Dock = System.Windows.Forms.DockStyle.Left;
            this.navForward.Location = new System.Drawing.Point(28, 6);
            this.navForward.Name = "navForward";
            this.navForward.Padding = new System.Windows.Forms.Padding(3);
            this.navForward.Size = new System.Drawing.Size(22, 24);
            this.navForward.TabIndex = 2;
            this.navForward.Click += new System.EventHandler(this.navForward_Click);
            // 
            // navPrevious
            // 
            this.navPrevious.BackColor = System.Drawing.Color.Transparent;
            this.navPrevious.BackgroundImage = global::WebKitBrowser.Properties.Resources.Previous;
            this.navPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPrevious.Location = new System.Drawing.Point(6, 6);
            this.navPrevious.Name = "navPrevious";
            this.navPrevious.Padding = new System.Windows.Forms.Padding(3);
            this.navPrevious.Size = new System.Drawing.Size(22, 24);
            this.navPrevious.TabIndex = 1;
            this.navPrevious.Click += new System.EventHandler(this.navPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(806, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 24);
            this.panel2.TabIndex = 0;
            // 
            // navSubmit
            // 
            this.navSubmit.BackColor = System.Drawing.Color.Transparent;
            this.navSubmit.BackgroundImage = global::WebKitBrowser.Properties.Resources.SwapRight;
            this.navSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.navSubmit.Location = new System.Drawing.Point(0, 0);
            this.navSubmit.Name = "navSubmit";
            this.navSubmit.Padding = new System.Windows.Forms.Padding(3);
            this.navSubmit.Size = new System.Drawing.Size(24, 24);
            this.navSubmit.TabIndex = 5;
            this.navSubmit.Click += new System.EventHandler(this.navSubmit_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 584);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Awesomium.Windows.Forms.AddressBox addressBox;
        private ImageButton navHome;
        private ImageButton navRefresh;
        private ImageButton navForward;
        private ImageButton navPrevious;
        private System.Windows.Forms.Panel panel2;
        private ImageButton navSubmit;
        private Awesomium.Windows.Forms.WebControl webControl1;

    }
}