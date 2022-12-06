using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WindowsFormsApp2
{
    internal class Gendub
    {
        static public int[,] ran(int range)
        {
            int[,] array = new int[range,range];
            Random random = new Random();
            for(int i = 0; i < range; i++)
            {
                for(int j = 0; j < range; j++) {
                    array[i,j] = random.Next(0,10); }
            }
            return array;
        }
        static public void duble(int[,] genericA, int[,] genericB, int start, int finish, int dobble_Col_Row, int size)
        {
           if(dobble_Col_Row == 1)
            {
                for(int i = 0; i < size; i++)
                {
                    genericB[finish,i] = genericA[start,i];

                }
            }else
            {
                for(int j = 0; j < size; j++)
                {
                    genericB[j, finish] = genericA[j, start];
                }
            }
        }
    }
    internal class One_Array
    {
        public int[] arr;

        public int length;

        public One_Array(int[] mass)
        {
            arr = mass; 
        }
        public static One_Array operator + (One_Array a, One_Array b)
        {
            for (int i = 0; i < b.arr.Length; i++)
            {
                a.arr[i] += b.arr[i];
            }
            return a;
        }
        public static One_Array operator * (One_Array a, int c)
        {
            for (int i = 0; i < a.arr.Length; i++)
            {
                a.arr[i] *= c;
            }
            return a;
        }
        public static One_Array operator ++ (One_Array a)
        {
            for (int i = 0; i < a.arr.Length; i++)
            {
                a.arr[i] += 3;
            }
            return a;
        }
        public static bool operator == (One_Array a, One_Array b)
        {
            bool result = true;
            for (int i = 0; i < a.arr.Length && i < b.arr.Length; i++)
            {
                result = a.arr[i] == b.arr[i];
                if (!result) break;
            }
            return result;
        }
        public static bool operator !=(One_Array a, One_Array b)
        { 
            return !(a==b);
        }
    }
}
