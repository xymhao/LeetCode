using System;
using System.Collections;

namespace DataStructure
{
    public class LinkHashMap
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable {{1, "2"}, {5, "2"}, {2, "2"}, {3, "2"}};
            hashtable[1] = "5";

            var value = hashtable[4];

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key);
            }
        }
    }
}