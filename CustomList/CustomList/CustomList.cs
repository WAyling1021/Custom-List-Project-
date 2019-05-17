using System;
namespace CustomList
{
        class CustomList<T>
        {

            //array holds all items in the list
            public T[] items = new T[1];

            //tells us how many items in the list
            public int Count { get { return count; } }
            private int count;

            //adds item to list (really the items array)
            public void Add(T item)
            {
                items[count] = item;
                count++;
            }
        }

       

}
