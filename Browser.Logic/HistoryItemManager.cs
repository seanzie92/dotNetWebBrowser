using Browser.Data.HistoryDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Browser.Logic
{
    public class HistoryItemManager
    {
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                

                results.Add(item);
            }
            return results;
        }

        public static void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        public static void DeleteHist()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }
        }

        public static void RemoveHist(string nom)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                string rowChecker = string.Format(string.Format("[{0}] {1} ({2})", row.Date, row.Title, row.URL));

                if (rowChecker == nom)
                {
                    adapter.Delete(row.Id, row.URL, row.Title, row.Date);
                }
            }
        }
    }
}
