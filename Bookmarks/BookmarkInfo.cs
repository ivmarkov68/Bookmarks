using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarks
{
    public class BookmarkInfo
    {
        public BookmarkInfo[] children { get; set; }

        public long date_added { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public int sync_transaction_version { get; set; }

        public string type { get; set; }

        public string url { get; set; }
    }

    public class BookmarkRoot
    {
        public BookmarkInfo[] children { get; set; }

        public long date_added { get; set; }

        public long date_modified { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public string type { get; set; }
    }

    public class Roots
    {
        public RootsHeader roots { get; set; }
        public string version { get; set; }
    }


    public class RootsHeader 
    {
        public BookmarkRoot bookmark_bar { get; set; }
        public BookmarkRoot other { get; set; }
        public string sync_transaction_version { get; set; }
    }
}
