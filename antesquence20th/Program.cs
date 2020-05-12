using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class4
    {
        static void Main(String[] args)
        {
            int select = 0;//몇 번 돌릴지
            int count = 1;
            int a = 0;
            int b = 0;//임시 저장
            Console.Write("몇 번 돌릴까?");
            select = int.Parse(Console.ReadLine());

            int[] array1 = new int[500];
            int[] array2 = new int[500];

            array1[0] = 1;


            for (int i = 0; i < select; i++)//선택한 만큼 돌린다.
            {
                while (array1[a] != 0)
                {//0 : 끝을 만날 때까지 돌린다.
                    if (array1[a] == array1[a + 1])
                    {
                        count++;
                    }
                    else
                    {
                        array2[b] = array1[a];       //세고 있던 수
                        array2[b + 1] = count;      //몇개나 있었는지
                        count = 1;                  //카운트 초기화
                        b = b + 2;                  //
                    }
                    a++;
                }
                //array1 = array2;//array를 계산된 array2로 대체
                Array.Copy(array2, array1, array2.Length);
                a = 0;//초기화;
                b = 0;
                Console.Write(i + 1 + "번째=");
                foreach (var arr in array1)
                {
                    if (arr == 0) break;
                    Console.Write(arr);
                }
                Console.WriteLine();
            }
        }
    }
}