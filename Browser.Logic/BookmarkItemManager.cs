using Browser.Data.BookmarkDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser.Logic
{
    class BookmarkItemManager
    {
        public void AddBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarkTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public List<BookmarkItem> GetItems()
        {
            var result = new List<BookmarkItem>();
            var adapter = new BookmarkTableAdapter();

            foreach (var row in adapter.GetData())
            {
                result.Add(new BookmarkItem() { URL = row.URL, Title = row.Title });
            }

            return result;
        }
    }
}
