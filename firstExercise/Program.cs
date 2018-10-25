using System;

namespace firstExercise
{
    class Program
    {


// o	Create a Loop that prints all values from 1-255
// o	Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
// o	Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5

        static void Main(string[] args)
        {
            // ===================   Task 1   ======================== 
            // for (int i = 1; i <= 255; i++ ){

            //     Console.Write(i + " ");

            // }

            // ===================   Task 2   ========================

            // for(int i = 1; i <= 100; i ++){

            //     if(i % 3 == 0 && i % 5 == 0){
            //         continue;
            //     }

            //     if(i % 3 == 0 || i % 5 == 0){
            //         Console.Write(i + " ");
            //     }

            // }
            // =====================   Task 3   ======================


            // for(int i = 1; i <= 100; i ++){

            //     if(i % 3 == 0 && i % 5 == 0){
            //         Console.Write(i+ "=>FizzBuzz," + " ");
            //     }

            //     if (i % 3 == 0){
            //         Console.Write(i+ "->Fizz," + " ");
            //     }
            //     if (i % 5 == 0){
            //         Console.Write(i+ "->Buzz,"+ " ");
            //     }

            // }


            // ====================    For Loop    ===========================

            // for(int i = 0; i <= 10; i+=2){

            //     Console.Write(i + " ");


            // }
            // ====================    While Loop    ===========================
            int num = 100;

            while(num >= 70){

                if (num >= 95){
                    Console.WriteLine("Congratz, you made an A+ " + num);
                }
                if(num >= 90 && num < 95){
                    Console.WriteLine("Hurray, you made an A "+ num);
                }
                if(num >= 85 && num < 90){
                    Console.WriteLine("Great Job you made a B+ "+ num);
                }
                if(num >=80 && num < 85){
                    Console.WriteLine("Good Work, you made a B "+ num);
                }
                if(num >= 75 && num < 80){
                    Console.WriteLine("You scored an C+ "+ num);
                }
                if(num >= 70 && num < 75){
                    Console.WriteLine("Awesome, you passed "+ num);
                }
                num -= 5;
            }




        }
    }
}
