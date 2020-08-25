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

        public T this[int index]
        {
            get 
            {
                return _items[index];
            }
               
            
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
            

            if (_count == _capacity)
            {
                _capacity += _capacity;
                temporary = new T[_capacity];
                for (int i = 0; i < _count; i++)
                {
                    temporary[i] = _items[i];
                }
                _items = temporary;
                
              

            }
            _items[_count] = item;
            _count++;
        }

    }
}
