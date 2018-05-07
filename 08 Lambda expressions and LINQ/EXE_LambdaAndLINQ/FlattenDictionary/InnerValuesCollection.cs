using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class InnerValuesCollection
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsFlat { get; set; }
        public int EntryNumber { get; set; }

        public InnerValuesCollection(string key, string value, int entry)
        {
            Key = key;
            Value = value;
            EntryNumber = entry;
        }      
    }
}
