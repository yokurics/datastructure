using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class MyKeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
