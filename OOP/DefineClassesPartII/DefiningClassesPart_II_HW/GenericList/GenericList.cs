using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T>
    {
        const int DefaultSize = 8;
        private T[] array;
        public long count { get; private set; }

        /*list constructors*/
        public GenericList()
        {
            array = new T[DefaultSize];
        }

        public GenericList(int size)
        {
            if (size >= 0)
            {
                array = new T[size];
            }
            else throw new ArgumentOutOfRangeException(String.Format("Invalid size {0}", size));
        }

        /*add element to list*/
        public void AddElement(T newElement)
        {
            if (count == array.Count())
            {
                DoubleListSize();
            }
            array[count] = newElement;
            count++;
        }

        /*double list size*/
        private void DoubleListSize()
        {
            T[] tmpArray = new T[count*2];
            Array.Copy(array, tmpArray, count);
            array = tmpArray;
        }

        /*remove element*/
        public void RemoveElement(int index)
        {
            try
            {
                if (index >= 0 && index < count)                                             //index <= count
                {
                    T[] tmpArray = new T[array.Count() - 1];
                    int counter = 0;
                    for (int i = 0; i < array.Count(); i++)
                    {
                        if (counter == index)
                        {
                            continue;                                                         //?
                        }
                        tmpArray[counter] = array[i];
                        counter++;
                    }
                    count--;
                    array = tmpArray;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index {} out of range.", index);
            }
        }

        /*insert element*/
        public void InserElement(int index, T element)
        {
            try
            {
                if (index <= count && index >= 0)
                {
                    T[] tmpArray = new T[array.Count() +1];
                    int counter = 0;
                    for (int i = 0; i < array.Count(); i++)
                    {
                        if (i == counter)
                        {
                            tmpArray[i] = element;
                        }
                        else
                        {
                            tmpArray[i] = array[counter];
                            counter++;
                        }
                    }
                    count++;
                    array = tmpArray;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index {} out of range.", index);
            }
        }

        /*indexer*/
        public T this[int index]
        {
            get 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return array[index];
                }
            }
            set 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    array[index] = value;
                }
            }
        }

        /*MIN*/
        public T Min()
        {
            if(count == 0)
            {
                throw new Exception("List is empty");
            }
            else if (count == 1)
            {
                return array[0];
            }
            else if (array[0] is IComparable<T>)
            {
                T min = array[0];
                for (int i = 0; i < count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(array[i]) > 0)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            else 
            {
                throw new TypeAccessException("The list is non-comparable and there isno Min value");
            }
        }

        /*MAX*/
        public T Max()
        {
            if (count == 0)
            {
                throw new Exception("List is empty");
            }
            else if (count == 1)
            {
                return array[0];
            }
            else if (array[0] is IComparable<T>)
            {
                T max = array[0];

                for (int i = 0; i < count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(array[i]) < 0)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else throw new TypeAccessException("The list is non-comparable and there isno Max value");
        }

        /*ToString*/
        public override string ToString()
        {
            T[] tmp = new T[count];
            Array.Copy(array, tmp, count);
            return String.Join(", ", tmp);
        }

        /*Cear*/
        public void Clear()
        {
            array = new T[0];
            count = 0;
        }

    }
}
