using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Bookmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"c:\bookmarks";
            JObject o1 = JObject.Parse(File.ReadAllText(filename));
            // read JSON directly from a file
            using (StreamReader file = File.OpenText(filename))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }

            var o3 = o1.ToObject<Roots>();

            var z = o3.roots.bookmark_bar.children.Traverse(x => x.children);

        }
    }
}
