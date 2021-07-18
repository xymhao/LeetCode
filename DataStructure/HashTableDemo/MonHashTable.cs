#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.HashTableDemo
{
    public class MonHashTable : IDictionary
    {
        /// <summary>
        /// 当前装在数量
        /// </summary>
        private int _loadSize;

        /// <summary>
        /// 装载因子
        /// </summary>
        private readonly float _loadFactor;

        private Bucket[] _buckets;


        private const int InitialSize = 3;

        /// <summary>
        /// 当前元素个数
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// 非线程安全
        /// </summary>
        public bool IsSynchronized { get; } = false;

        public MonHashTable() : this(0, 1.0f)
        {
        }

        public MonHashTable(int capacity, float loadFactor)
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
            int hashSize = Math.Max((int)rawSize, InitialSize);
            _buckets = new Bucket[hashSize];

            _loadSize = (int) (_loadFactor * hashSize);
        }

        /// <summary>
        /// 承载对象
        /// </summary>
        private struct Bucket
        {
            public object? Key;
            public object? Val;
            public int HashColl; // Store hash code; sign bit means there was a collision.
        }


        public void Add(object key, object? value)
        {
            if (key == null)
            {
                throw new ArgumentException(nameof(key));
            }

            if (Count >= _loadSize)
            {
                //扩容
                Expand();
            }

            var hashColl = InitHash(key);
            Insert(key, value, hashColl, _buckets);
            Count++;
        }

        private static void Insert(object key, object? value, uint hashColl, Bucket[] buckets)
        {
            var number = hashColl % buckets.Length;
            var nTry = 0;
            //判断是否发生散列冲突
            do
            {
                //未使用的情况下插入
                if (buckets[number].Key == null)
                {
                    buckets[number] = new Bucket()
                    {
                        Key = key,
                        Val = value,
                        HashColl = (int) hashColl
                    };
                    return;
                }

                number = (number + 1) % buckets.Length;
                nTry++;
            } while (nTry < buckets.Length);
        }

        /// <summary>
        /// 当超过
        /// </summary>
        private void Expand()
        {
            //将原数组扩大到以前的两倍
            int rawSize = _buckets.Length * 2;
            var newBucket = new Bucket[rawSize];
            ReHash(newBucket);
        }

        private void ReHash(Bucket[] newBucket)
        {
            foreach (Bucket bucket in _buckets)
            {
                if (bucket.Key == null)
                {
                    continue;
                }

                var hashColl = InitHash(bucket.Key);
                Insert(bucket.Key, bucket.Val, hashColl, newBucket);
            }

            _buckets = newBucket;
            _loadSize = (int) (_loadFactor * _buckets.Length);
        }


        private uint InitHash(object key)
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
                var hash = InitHash(key);
                var number = hash % _buckets.Length;
                return _buckets[number].Val;
            }
            set => throw new NotImplementedException();
        }

        public ICollection Keys
        {
            get
            {
                return _buckets.Where(x => x.Key != null).Select(x => x.Key).ToList();
            }
        }

        public ICollection Values { get; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }


        public object SyncRoot { get; }
    }
}