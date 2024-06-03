using System;

namespace Fibonacci{
    class Fibonacci(){
        public static void Main(string[] args){
            Greetings();
            string? userInput = Console.ReadLine();
            Console.WriteLine(Fibo(userInput));
        }

        static void Greetings(){
            Console.WriteLine("Hello! This app will print out the Fibonacci Sequence to any number you feed it! Make sure it is an integer!");
        }

        static int Fibo(string? userInput){
            int a = 0;
            int b = 1;
            int c = 0;

            int nth = 0;

            if(int.TryParse(userInput, out int i)){
                nth = Convert.ToInt32(userInput);

                if (nth == 0)
                {
                    return a;
                }
                else {
                    for (int x = 2; x <= nth; x++){
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    return b;
                }
            }
            else{
                Console.WriteLine("ERROR: Not an integer!");
                return 0;
            }
        }
    }
}