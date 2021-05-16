using System.Collections.Generic;


namespace Exercise_3
{
    interface IMyDictionary<TKey,TValue>
    {
        List<TKey> Key { get; }
        List<TValue> Value { get; }
        TValue this[TKey index] { get; }
    }
}
