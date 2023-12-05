using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletingByIndexInAnArray
{
    public class RemoveElemArr
    {
        public RemoveElemArr()
        {
            
        }

        public void RemoveAt <T>(ref T[] arr,int index)
        {
            T[] newArray = new T[arr.Length-1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
        }
        public void RemoveFirst<T>(ref T[] array)
        {
            RemoveAt<T>(ref array, 0);
        }
        public void RemoveLast<T>(ref T[] array)
        {
            RemoveAt<T>(ref array, array.Length - 1);
        }
    }
}
