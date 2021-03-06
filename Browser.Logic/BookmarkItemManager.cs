using Browser.Data.BookmarkDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser.Logic
{
    public class BookmarkItemManager
    {
        public static void AddBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarkTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarkTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static void DeleteBook(string candidate)
        {
            var adapter = new BookmarkTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string rowChecker = string.Format(string.Format("{0} ({1})", row.URL, row.Title));

                if (rowChecker == candidate)
                {
                    adapter.Delete(row.Id, row.URL, row.Title);
                }
            }
        }
    }
}
