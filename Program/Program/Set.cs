using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
namespace COMPE361
{
    // Decleare delegate
    public delegate bool F<T>(T elt);
    public class Set<T> : IEnumerable<T>
    {
        // Properties
        protected List<T> Data;
        public int Count
        {
            get
            {
                return Data.Count();
            }
        }
        public bool IsClear
        {
            get
            {
                return !Data.Any();
            }
        }
        // Methods, default constructor

        public Set()
        {
            Data = new List<T>();
        }
        // Parametrized constructor
        public Set(IEnumerable<T> e)
        {
            Data = new List<T>();
            // Initialize
            foreach (var element in e)
            {
                // element is already my set check it
                if (!Data.Contains(element))
                {
                    Data.Add(element);
                }
            }
        }
        // use overloading + to set union
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            Set<T> union = new Set<T>(lhs);
            // Add elements which is deffered from each other
            foreach (var data in rhs)
            {
                if (!union.Contains(data))
                {
                    union.Data.Add(data);
                }
            }

            return union;
        }
        // adding item to set
        public virtual bool Add(T item)
        {
            if (!Data.Contains(item))
            {
                Data.Add(item);
                return true;
            }
            return false;
        }
        // Removing item from the set
        public bool Remove(T item)
        {
            if (Data.Contains(item))
            {
                Data.Remove(item);
                return true;
            }
            return false;
        }

        public bool Contains(T item) => Data.Contains(item);

        public Set<T> Filter(F<T> filterFunction)
        {
            Set<T> filteredSet = new Set<T>();
            foreach (var elt in Data)
            {
                if (filterFunction(elt))
                {
                    filteredSet.Data.Add(elt);
                }
            }
            return filteredSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var elt in Data)
            {
                yield return elt;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }
    }
}