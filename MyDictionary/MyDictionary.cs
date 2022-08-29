using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        KeyValuePair<TKey, TValue>[] _items;
        KeyValuePair<TKey, TValue>[] _tempArray;

        public MyDictionary()
        {
            _items = new KeyValuePair<TKey, TValue>[0];
        }

        public void Add(TKey key,TValue value)
        {
            if (KeyControl(key))
            {
                _tempArray = _items;
                _items = new KeyValuePair<TKey, TValue>[_items.Length+1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _items[i] = _tempArray[i];
                }
                _items[_items.Length - 1] = new KeyValuePair<TKey, TValue>(key,value);
            }
            else
            {
                Console.WriteLine("Hatalı anahtar girişi");
            }
        }

        private bool KeyControl(TKey key)
        {
            bool control = true;

            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Key.ToString()==key.ToString())
                {
                    control = false;
                }
            }
            return control;
        }
        public int Count
        {
            get { return _items.Length; }
        }
        public void Show()
        {
            foreach (var item in _items)
            {
                Console.WriteLine("Key: "+item.Key+ "   Value: "+item.Value);
            }
        }
    }
}
