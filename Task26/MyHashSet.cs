using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    internal class MyHashSet<K, T> : MyHashMap<K, T>
    {
        public MyHashSet() : base()
        {
        }
        public MyHashSet(K[] mas) : base()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (!ContainsKey(mas[i]))
                {
                    Put(mas[i], default);
                }
            }
        }
        public MyHashSet(int initialCapacity, float loadFactor) : base(initialCapacity, loadFactor)
        {
        }
        public MyHashSet(int initialCapacity) : base(initialCapacity)
        {
        }
        public void Add(K x)
        {
            if (!ContainsKey(x))
            {
                Put(x, default);
            }
        }
        public void AddAll(K[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (!ContainsKey(mas[i]))
                {
                    Put(mas[i], default);
                }
            }
        }
        public bool Contains(K x)
        {
            return ContainsKey(x);
        }
        public bool ContainsAll(K[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (!ContainsKey(mas[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public void RemoveAll(K[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Remove(mas[i]);
            }
        }
        public void RetainAll(K[] mas)
        {
            MyHashMap<K, T> newSet = new MyHashMap<K, T>();
            for (int i = 0; i < mas.Length; i++)
            {
                newSet.Put(mas[i], default);
            }
            table = newSet.table;
            size = newSet.size;
            loadFactor = newSet.loadFactor;
            numOfFullBuckets = newSet.numOfFullBuckets;
        }
        public Entry<K, T>[] ToArray()
        {
            return EntrySet();
        }
        public K[] ToArrayK()
        {
            return KeySet();
        }
        public Entry<K, T>[] ToArray(Entry<K, T>[] mas)
        {
            if (mas == null)
            {
                return EntrySet();
            }
            Entry<K, T>[] NewMas = EntrySet();
            if (mas.Length > NewMas.Length)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = NewMas[i];
                }
                return mas;
            }
            else
            {
                throw new Exception("Wrong function call");
            }
        }
    }
}
