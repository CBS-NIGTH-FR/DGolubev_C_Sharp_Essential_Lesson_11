using System;


namespace Exercise_4
{
    class MyArrayList
    {
        private object[] array;

        public MyArrayList()
        {
            array = new object[0];
        }
        public object this[int index] { get { return array[index]; } }

        public int Counter => array.Length;

        
        public void Add(object item)
        {
            object[] tmp_array = new object[Counter + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tmp_array[i] = array[i];
            }
            tmp_array[array.Length] = item;
            array = tmp_array;
        }

        public void Clear()
        {
            array = new object[0];
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }

            }
            return false;
        }

        public int IndexOf(object item)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }
            return index;
        }

        public void Insert(int index, object item)
        {
            array[index] = item;
        }

        public bool Remove(object item)
        {
            object[] tmp_array = new object[Counter - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    array[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            array[index] = null;
            object[] tmp_array = new object[Counter - 1];
            for (int i = 0; i < array.Length; i++)
            {
                tmp_array[i] = array[i];
            }
            array = tmp_array;
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i]+"\n";
            }
            return $"Размер ArrayList {Counter}\nСодержание:\n{str}";
        }
    }
}
