using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticQueue
{
    class StaticPriorityQueue<T>
    {
        private T[] array;
        private int[] priorities;
        private int indexEnd;

        public StaticPriorityQueue()
        {
            array = new T[2];
            priorities = new int[2];
            indexEnd = -1;
        } //Constructor

        public int Count
        {
            get
            {
                return indexEnd + 1;
            }
        } //public Count

        public void Clear()
        {
            array = new T[2];
            priorities = new int[2];
            indexEnd = -1;
        } //Clear

        public void Enqueue(T value, int priority)
        {
            //Check if array is big enough and resize if necessary
            if (Count == array.Length)
            {
                Array.Resize(ref array, array.Length * 2);
                Array.Resize(ref priorities, array.Length * 2);
            }

            //Search for insert position - after last element with the same priority
            //  E.g. Insert element with priority 3 into 1, 1, 2, 3, 3, 4, 5, 5
            //  Insert position will be 5 (where 4 currently is) 
            //  Move all the other elements down
            int insertPos = indexEnd + 1;
            for (int i = indexEnd; i >= 0; i--)
            {
                if (priority < priorities[i])
                {
                    array[i + 1] = array[i];
                    priorities[i + 1] = priorities[i];
                    insertPos--;
                } //if
            } //for

            //Insert element in its position and increment index
            array[insertPos] = value;
            priorities[insertPos] = priority;
            indexEnd++;
        } //Enqueue priority

        public T Dequeue()
        {
            if (Count > 0)
            {
                //Value to be returned
                T value = array[0];
                //Move rest of elements forward
                for (int i = 1; i <= indexEnd; i++)
                {
                    array[i - 1] = array[i];
                    priorities[i - 1] = priorities[i];
                }

                //Decrement index of last element
                indexEnd--;
                return value;
            }
            return default(T);
        } //Dequeue

        public T Peek()
        {
            if (Count > 0)
                return array[0];
            else
                return default(T);
        } //Peek

        public bool Contains(T value)
        {
            int i = 0;
            while (i <= indexEnd)
            {
                if (array[i].Equals(value))
                    return true;
                else
                    i++;
            } //while
            return false;
        } //Contains

        public int Position(T value)
        {
            int pos = 0;
            while (pos <= indexEnd)
            {
                if (array[pos].Equals(value))
                    return pos+1;
                else
                    pos++;
            } //while
            return -1;
        }

    } //class StaticPriorityQueue
} //namespace
