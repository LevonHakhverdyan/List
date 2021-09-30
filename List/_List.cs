using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class _List
    {
        private int[] _items;
        int size;
        private int _capacity = 4;
        public _List()
        {
            _items = new int[_capacity];
        }
        public _List(int capacity)
        {
            _items = new int[capacity];
            _capacity = capacity;

        }
        public void Add(int source)
        {
            if (_items.Length > size)
            {
                _items[size] = source;
                size++;
            }
            else
            {
                _capacity = _capacity * 2;
                Array.Resize(ref _items, _capacity);
                _items[size] = source;
                size++;
            }


        }

    }
}
