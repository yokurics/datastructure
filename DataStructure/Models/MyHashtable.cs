using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace DataStructure.Models
{
    public class MyHashtable<TKey, TValue>
    {
        private MyOneWayLinkedList<MyKeyValuePair<TKey, TValue>>[] _table { get; set; }
        private int _capacity { get; }

        public MyHashtable()
        {
            _capacity = 1000;
            _table = new MyOneWayLinkedList<MyKeyValuePair<TKey, TValue>>[_capacity];
        }

        public TValue this[TKey key]
        {
            get {
                return GetValue(key);
            }
            set {
                SetValue(key, value);
            }
        }

        public TValue GetValue(TKey key)
        {
            var hashKey = GetHashKey(key);
            var items = _table[hashKey];

            if (items == null)
            {
                throw new Exception("Key not found.");
            }

            var node = items.First;

            while (node != null)
            {
                if (node.Value.Key.Equals(key))
                {
                    break;
                }

                node = node.Next;
            }

            return node.Value.Value;
        }

        private void SetValue(TKey key, TValue value)
        {
            var hashKey = GetHashKey(key);
            var items = _table[hashKey];

            if (items == null)
            {
                items = new MyOneWayLinkedList<MyKeyValuePair<TKey, TValue>>();
                _table[hashKey] = items;
            }
            else
            {
                var node = items.First;

                while (node != null)
                {
                    if (node.Value.Key.Equals(key))
                    {
                        items.Remove(node);
                        break;
                    }

                    node = node.Next;
                }
            }

            items.AddLast(new MyKeyValuePair<TKey, TValue>
            {
                Key = key,
                Value = value
            });
        }

        public int GetHashKey(TKey key)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(key.ToString()));
            var hashCode = new BigInteger(hashBytes);
            return Math.Abs((int)BigInteger.Remainder(hashCode, new BigInteger(_capacity)));
        }
    }
}
