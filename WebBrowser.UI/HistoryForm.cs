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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        protected void HistoryForm_Load(object sender, EventArgs e)
        {
            var items = HistoryItemManager.GetItems();
            foreach (var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }



        }

        private void histSearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryItemManager.GetItems();
            historyListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(histSearchBox.Text))
                {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void histDeleteButton_Click(object sender, EventArgs e)
        {
            if (historyListBox.SelectedIndex >= 0)
            {
                string nom = historyListBox.GetItemText(historyListBox.SelectedItem);
                HistoryItemManager.RemoveHist(nom);
                historyListBox.Items.RemoveAt(historyListBox.SelectedIndex);
            }
        }

        private void histClearButton_Click(object sender, EventArgs e)
        {            
            HistoryItemManager.DeleteHist();            
            historyListBox.Items.Clear();
        }
    }
}
