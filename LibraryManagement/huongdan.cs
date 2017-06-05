using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class huongdan : Form
    {
        public huongdan()
        {
            InitializeComponent();
        }

        private void huongdan_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }
    }
}
