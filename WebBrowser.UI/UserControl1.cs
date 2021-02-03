using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void exitBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Sean Zetterlund. szz0060. Python ftw!");
        }

        //navigate function 
        private void NavigateToPage()
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        //press go to navigate to url
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        //keypress enter for url
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }
    }
}
