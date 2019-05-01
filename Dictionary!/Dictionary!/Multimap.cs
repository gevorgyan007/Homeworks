using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_
{
    public class Multimap<TValue,TKey> : IDictionary<TKey, IEnumerable<TValue> >
    {

        Dictionary<TKey, IEnumerable<TValue>> _dictionary =
          new Dictionary<TKey, IEnumerable<TValue>>();

        public void Add(TKey key, TValue value)
        {
            // Add a key.
            IEnumerable<TValue> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                (list as List<TValue>).Add(value);
            }
            else
            {
                var list1 = new List<TValue>();
                list1.Add(value);
                this._dictionary[key] = list1;
            }
        }

        public void Remove(TKey key, TValue value)
        {
            // Add a key.
            IEnumerable<TValue> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                (list as List<TValue>).Remove(value);
                if ((list as List<TValue>).Count == 0)
                    _dictionary.Remove(key);
            }
        }

        public bool ContainsKey(TKey key)
        {
           return _dictionary.ContainsKey(key);

        }

        public bool Remove(TKey key)
        {
           return _dictionary.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out IEnumerable<TValue>  value)
        {
           bool r = _dictionary.TryGetValue(key, out  value);
           return r;
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<TKey, IEnumerable<TValue>> item)
        {
            
            _dictionary.Add(item.Key,item.Value.ToList());

        }

        public void Clear()
        {
            _dictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, IEnumerable<TValue>> item)
        {
            return this.ContainsKey(item.Key);
        }

        public void CopyTo(KeyValuePair<TKey, IEnumerable<TValue>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, IEnumerable<TValue>> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, IEnumerable<TValue>>> GetEnumerator()
        {
           var q = this._dictionary.GetEnumerator();
            return q;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._dictionary.GetEnumerator();
        }

        public void Add(TKey key, IEnumerable<TValue> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                // Get all keys.
                return this._dictionary.Keys;
            }
        }

        ICollection<TKey> IDictionary<TKey, IEnumerable<TValue>>.Keys => _dictionary.Keys;

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;

        ICollection<IEnumerable<TValue>> IDictionary<TKey, IEnumerable<TValue>>.Values => _dictionary.Values;

        

        public IEnumerable<TValue> this[TKey key]
        {
            get
            {
                // Get list at a key.
                IEnumerable<TValue> list;
                if (!this._dictionary.TryGetValue(key, out list))
                {
                    list = new List<TValue>();
                    this._dictionary[key] = list;
                }
                return list;
            }
            set
            {
                this._dictionary[key] = value.ToList();
            }
        }
    }
}

