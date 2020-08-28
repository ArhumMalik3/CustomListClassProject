using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CustomListClass 
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        public T this[int index]
        {
            get 
            {
                if (index <= _count && index >= 0)
                {
                    return _items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                if (index <= _count && index >= 0)
                {
                    _items[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
               
            
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        

        public void Add(T item)
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

        public bool Remove(T item)
        {
            int indexLocation;
            T[] temporary;
            temporary = new T[_capacity];
            //check to see if item which was removed was in the list
            //if no do nothing/ dont run this method
            //if it is
            //get its location of first instance in array

            for (int i = 0; i < _count; i++)
            {
                bool status = _items[i].Equals(item);

                
                if (status)
                {
                    indexLocation = i;
                    
                    for (int j = i; j < _count; j++)
                    {
                        
                        if (j == indexLocation)
                        {
                            continue;
                        }
                        temporary[j-1] = _items[j];
                    }
                    _items = temporary;
                    _count--;
                }

                if (status)
                {
                    return true;
                }

                temporary[i] = _items[i];
                
            }

            return false;
             //replace with location of first instance
           
            //make a new array that doesnt have the first instance of that item
            //make sure the count goes donw 1
            
            // make sure all the indexes are correct
        }

        public override string ToString()
        {
            //return a string that represents the object instance
            //
            string tempString = "";
            for (int i = 0; i < _count; i++)
            {

                tempString += _items[i];
                if (i != _count - 1)
                {
                    tempString += ", ";
                }
                
            }
            
            return tempString;
        }

        public static CustomList<T> operator +(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> combinedLists = new CustomList<T>();
            for (int i = 0; i < customList1.Count; i++)
            {
                combinedLists.Add(customList1[i]);
            }

            for (int i = 0; i < customList2.Count; i++)
            {
                combinedLists.Add(customList2[i]);
            }
            return combinedLists;

        }

        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> combinedLists = new CustomList<T>();
            for (int i = 0; i < customList2.Count; i++)
            {
                for (int j = 0; j < customList1.Count; j++)
                {
                    
                    if (customList1[j].Equals(customList1[i]))
                    {
                        customList1.Remove(customList2[i]);
                    }

                }
            }

            combinedLists += customList1;
            return combinedLists;

        }

        public CustomList<T> Zip(CustomList<T> customList1)
        {
            CustomList<T> zippedList= new CustomList<T>();
            int count = _count + customList1._count;
            int index = 0;

            while (count > 0)
            {
                if(_count == 0)
                {
                    zippedList.Add(customList1[index]);
                    count--;
                    index++;
                }
                else if (zippedList._count == 0)
                {
                    zippedList.Add(_items[index]);
                    count--;
                    index++;
                }

                else
                {
                    zippedList.Add(_items[index]);
                    count--;
                    zippedList.Add(customList1[index]);
                    count--;
                    index++;
                }
            }
            return zippedList;
        }

        //public bool ContainsValue(T item)
        //{
        //    bool found = false;
        //    foreach (T value in _items)
        //    {
        //        if (value == item)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }
        //    return found;
        //}


    }
}
