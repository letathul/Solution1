using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenClass<T> where T : struct
    {

        private List<T> list;


        public GenClass() {
            list = new List<T>();

        }

        public void Add(T item) { 
        
            list.Add(item);
        }

        public T? getItem(int index) {

            if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException("Item not found");

      
            return list[index];
        
        }

        public List<T> GetSortedList()
        {
            List<T> sortedList = new List<T>(list);
            sortedList.Sort();
            sortedList.Reverse();
            return sortedList;
        }

    }
}
