using System;

namespace Zuzya
{
    public class Palochka
    {
        public static int Kolvo_elementov(int[] array, int b)
        {//0
            int count = 1;//1
            for (int i = 0; i > array.Length; i++)//2
                if (array[i] >= b)//3
                {//4
                    count += 1;//5
                }//6
            return count; //7
        }//8
    }
}
