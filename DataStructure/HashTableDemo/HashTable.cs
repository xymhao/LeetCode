using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.HashTableDemo
{
    public class HashTable : IDictionary
    {
        /// <summary>
        /// 当前极客的装在数量
        /// </summary>
        private int _loadSize;

        /// <summary>
        /// 装载因子
        /// </summary>
        private float _loadFactor;

        private int _count;

        private int _occupancy;


        private const int InitialSize = 3;

        public HashTable() : this(0, 1.0f)
        {
        }

        public HashTable(int capacity, float loadFactor)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));
            if (!(loadFactor >= 0.1f && loadFactor <= 1.0f))
                throw new ArgumentOutOfRangeException(nameof(loadFactor));

            // Based on perf work, .72 is the optimal load factor for this table.  
            _loadFactor = 0.72f * loadFactor;

            double rawSize = capacity / _loadFactor;
            if (rawSize > int.MaxValue)
                throw new ArgumentException(nameof(capacity));

            // Avoid awfully small sizes
            int hashSize = (rawSize > InitialSize) ? HashHelpers.GetPrime((int) rawSize) : InitialSize;
            _buckets = new Bucket[hashSize];

            _loadSize = (int) (_loadFactor * hashSize);
            _loadFactor = loadFactor;
        }

        /// <summary>
        /// 承载对象
        /// </summary>
        private struct Bucket
        {
            public object? key;
            public object? val;
            public int hash_coll; // Store hash code; sign bit means there was a collision.
        }

        private Bucket[] _buckets = null!;

        public void Add(object key, object? value)
        {
            if (key == null)
            {
                throw new ArgumentException(nameof(key));
            }

            if (_count >= _loadFactor)
            {
                //扩容
            }

            var hashColl = InitHash(key, _buckets.Length);
            var number = hashColl % _buckets.Length;
            var nTry = 0;
            //判断是否发生散列冲突
            do
            {
                //未使用的情况下插入
                if (_buckets[number].key == null)
                {
                    _buckets[number] = new Bucket()
                    {
                        key = key,
                        val = value,
                        hash_coll = (int) hashColl
                    };
                    return;
                }

                number = (number + 1) % _buckets.Length;
                nTry++;
            } while (nTry < _buckets.Length);

        }

        private void Expand()
        {
            //将原数组扩大到以前的两倍
            int rawSize = HashHelpers.ExpandPrime(_buckets.Length);
            var newBucket = new Bucket[rawSize];
            foreach (Bucket bucket in _buckets)
            {
                
            }
            
        }


        private uint InitHash(object key, int hashSize)
        {
            return (uint) key.GetHashCode() & int.MaxValue;
        }

        protected virtual int GetHash(object key)
        {
            return key.GetHashCode();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedSize => false;
        public bool IsReadOnly => false;

        public object? this[object key]
        {
            get
            {
                var hash = InitHash(key, _buckets.Length);
                var number = hash % _buckets.Length;
                return _buckets[number].val;
            }
            set => throw new NotImplementedException();
        }

        public ICollection Keys { get; }
        public ICollection Values { get; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count => _count;

        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
    }
}