using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next() % 1000;
           // Console.WriteLine("컴퓨터가 생각한 숫자 : " + num);

            while (true)
            {
                Console.Write("숫자를 입력해주세요.: ");
                int mynum = int.Parse(Console.ReadLine());

                if (num == mynum)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                 
                if (mynum < num) { Console.WriteLine(mynum + "보다는 큰 숫자입니다."); }
                else if (mynum > num) { Console.WriteLine(mynum + "보다는 작은 숫자입니다."); }
                else { Console.WriteLine("잘못입력하셨습니다."); }
            }
        }
    }
}