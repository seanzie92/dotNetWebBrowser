﻿using System;
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
    public partial class WebPage : Form
    {
        public WebPage()
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

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            tabControl1.TabPages.Add(newTabPage);
            UserControl1 newTabControl = new UserControl1();
            newTabControl.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(newTabControl);
            
            
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab.Dispose();
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyItem = new HistoryForm();
            historyItem.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new BookmarkForm();
            bookmarkItem.ShowDialog();
        }
    }
}
