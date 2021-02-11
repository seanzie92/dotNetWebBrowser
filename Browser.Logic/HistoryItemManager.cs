using Browser.Data.HistoryDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Browser.Logic
{
    class HistoryItemManager
    {
        public List<HistoryItem> GetItems()
        {
            var result = new List<HistoryItem>();
            var adapter = new HistoryTableAdapter();

            foreach(var row in adapter.GetData())
            {
                result.Add(new HistoryItem() { URL = row.URL, Title = row.Title, Date = row.Date });
            }

            return result;
        }

        public void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }
    }
}
