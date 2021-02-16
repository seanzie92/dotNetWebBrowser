using System;
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
    public partial class BookmarkForm : Form
    {
        public BookmarkForm()
        {
            InitializeComponent();
        }

        private void BookmarkForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkItemManager.GetItems();
            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.URL, item.Title));
            }
        }

        private void bookSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkItemManager.GetItems();
            bookmarkListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.URL.Contains(bookSearchTextBox.Text))
                {
                    bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.URL, item.Title));
                }
            }
        }

        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            string nom = bookmarkListBox.GetItemText(bookmarkListBox.SelectedItem);
            BookmarkItemManager.DeleteBook(nom);
            bookmarkListBox.Items.RemoveAt(bookmarkListBox.SelectedIndex);
        }
    }
}
