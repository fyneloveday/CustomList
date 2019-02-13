using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T>: IEnumerable
    {
        private int capacity = 4;
        private int count;
        private T[] items;

        public MyCustomList()
        {
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public int Count
        {
            get 
         {
            return count;
         }

        }



        public void Add(T item)
        {
            count++;
            if (count >= capacity)
            {
                capacity = capacity * 2;
                T[] temp = new T[capacity];
                for (int i = 0; i > count; i++)
                {
                    temp[i] = items[i];
                }
                temp[count] = item;
            }
            else if (count < capacity) 
            {
                items[count - 1] = item;
            }
     
        }

        public void Remove(T item)
        {
            
            for (int i = capacity - 1; i <= count; i--)
            {
                count--;
                if (items[i].Equals(item))
                {
                    items[i] = items[i - 1];
                    count--; 
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public static MyCustomList<T> operator+ (MyCustomList<T> load1, MyCustomList<T> load2)
        {
            //MyCustomList<int> load1 = new MyCustomList<int>() { 5, 15, 25, 35, 45 };
            //MyCustomList<int> load2 = new MyCustomList<int>() { 10, 20, 30, 40, 50 };
            //MyCustomList<int> result = load1 + load2;
            MyCustomList<T> result = new MyCustomList<T>();
            for (int i = 0; i < load1.count; i++)
            {
                result.Add(load1[i]);
            }
            for (int i = 0; i < load2.count; i++)
            {
                result.Add(load2[i]);
            }


            return result;
        }

        public static MyCustomList<T> operator- (MyCustomList<T> load1, MyCustomList<T> load2)
        {
            //MyCustomList<int> unload1 = new MyCustomList<int>() { 5, 15, 25, 35, 45 };
            //MyCustomList<int> unload2 = new MyCustomList<int>() { 10, 20, 30, 40, 50 };
            //MyCustomList<int> result = unload1 - unload2;
            MyCustomList<T> result = new MyCustomList<T>();
            for (int i = 0; i < load1.count; i++)
            {
                result.Remove(load1[i]);
            }

            return result;
        }

        public MyCustomList<T> Zip (MyCustomList<T> load1, MyCustomList<T> load2)
        {
            MyCustomList<T> result = new MyCustomList<T>();
            for (int i = 0; i < load1.count; i++)
            {
                result.Add(load1[i]);
                result.Add(load2[i]);
            }

            return result;
        }
        
            // MyCustomList<int>fives = new MyCustomList<int>() { 5, 15, 25, 35, 45 };
            // MyCustomList<int>tens = new MyCustomList<int>() { 10, 20, 30, 40, 50 };

            //fives.Zip(tens, (f, t) => f * t;


        }     

    }

