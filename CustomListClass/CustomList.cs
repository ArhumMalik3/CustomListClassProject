using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void Remove(T item)
        {
            int indexLocation;
            //check to see if item which was removed was in the list
            //if no do nothing/ dont run this method
            //if it is
            //get its location of first instance in array
            
            for (int i = 0; i < _count; i++)
            {
                bool status = _items[i].Equals(item);
                if (status)
                {

                }
            }
            indexLocation = 0; //replace with location of first instance
            for (int i = 0; i < _count; i++)
            {
                if (i== indexLocation) 
                {
                    continue;
                }
            }
            //make a new array that doesnt have the first instance of that item
            //make sure the count goes donw 1
            _count--;
            // make sure all the indexes are correct

            foreach (T thing in _items)
            {
               // _items[_count - 1];
            }
            

        }

        public bool ContainsValue(T item)
        {
            bool found = false;
            foreach (T value in _items)
            {
                if (value == item)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public void RemoveCan(Can can)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name == can.name)
                {
                    inventory.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
