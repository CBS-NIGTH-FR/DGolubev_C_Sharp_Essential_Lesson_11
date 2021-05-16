using System.Collections.Generic;


namespace Exercise_3
{
    class MyDictionary: IMyDictionary<string, string>
    {
        delegate (string, string) CoupleWords(string key, string value);

        public int Counter => Key.Count;
        public List<string> Key { get; private set; }
        public List<string> Value { get; }
        CoupleWords Pair = (string a, string b) => { return (a, b); };

        public MyDictionary()
        {
            Key = new List<string>();
            Value = new List<string>();
        }
        public void Add(string key, string value)
        {
            var pair = Pair(key, value);
            Key.Add(pair.Item1);
            Value.Add(pair.Item2);
        }

        public string this[string index] 
        { 
            get
            {
                for (int i = 0; i < Key.Count; i++)
                {
                    if(Key[i] == index)
                    {
                        return $"Значением по индексу {index} явлется {Value[i]}";
                    }
                }
                return "Значение не найдено";
            }
        }
        public override string ToString()
        {
            string str = string.Empty;

            for (int i = 0; i < Key.Count; i++)
            {
                str+= Key[i] + " " + Value[i] +"\n";
            }

            return str;

        }
    }
}
