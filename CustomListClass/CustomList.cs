using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CustomListClass
{
    public class CustomList<T>
    {
        T[] _items;

        int _capacity;
        int _count;


        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public T this[T index]
        {
            get => _items[index];
            
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Add(ref T item)
        {
            T[] temporary;
            T[] _new_items;

            if (_count == _capacity)
            {
                temporary = new T[_capacity];
                temporary = _items;
                _capacity = _capacity * 2;
                _new_items = new T[_capacity];
                _new_items = temporary;

            }
            _items[_count] = item;
            _count++;
        }

    }
}
