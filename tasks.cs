using System;

namespace Task
{
    class Task3
    {
        static void Main(string[] args)
        {
    

        }

        #region task2
        static void task2(string[] s, char c)
        {
            foreach(string str in s)
            {
                foreach(char c2 in str)
                {
                    if (c == c2)
                    {
                        Console.WriteLine(str);
                        break;
                    }
                }
            }
        }
        #endregion
        #region task1
        static void CustomSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        #endregion
        
    }
}