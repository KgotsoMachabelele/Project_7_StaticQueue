using System;

namespace StaticQueue
{
    class StaticQueue<T> : IQueue<T>
    {
        private T[] array;
        private int indexEnd;

        public StaticQueue()
        {
            array = new T[2];
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
            indexEnd = -1;
        } //Clear

        public void Enqueue (T value)
        {
            //Check if array is big enough and resize if necessary
            if (Count == array.Length)
                Array.Resize(ref array, array.Length * 2);
            //Increment index and add element to the end of the queue
            array[++indexEnd] = value;
        } //Enqueue

        public T Dequeue()
        {
            if (Count > 0)
            {
                //Value to be returned
                T value = array[0];
                //Move rest of elements forward
                for (int i = 1; i <= indexEnd; i++)
                    array[i - 1] = array[i];

                //Decrement index of last element
                indexEnd--;
                return value;
            }
            return default(T);
        } //Enqueue

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
            int i = 0;
            while (i <= indexEnd)
            {
                if (array[i].Equals(value))
                    return i;
                else
                    i++;
            } //while
            return -1;
        } //int Position

    } //class
} //namespace
