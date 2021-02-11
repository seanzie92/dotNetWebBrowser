﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Browser.Logic;

namespace WebBrowser.UI
{

    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Stack<string> forwardLinks = new Stack<string>();
        public Stack<string> backwardLinks = new Stack<string>();

        private void Navigate_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            forwardLinks.Push(webBrowser1.Url.ToString());
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            backwardLinks.Push(webBrowser1.Url.ToString());
            webBrowser1.GoBack();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new BookmarkItem();
            bookmarkItem.URL = toolStripTextBox1.Text;
            bookmarkItem.Title = webBrowser1.DocumentTitle;
            BookmarkItemManager.AddBookmarkItem(bookmarkItem);
        }
    }
}
