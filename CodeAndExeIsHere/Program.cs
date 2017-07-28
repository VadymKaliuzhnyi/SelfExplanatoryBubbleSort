using System;

namespace Sorter {
    public class Program {
        public static void Main (string[] args) {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int w = 0;
            int w2 = 0;
            int w3 = 0;

            for (int z = 0; z < numbers.Length; z++) {
                Console.WriteLine ("###################################");
                ++w;
                Console.WriteLine ("Loop 1, round: " + w);

                bool flag = true;

                for (int i = 0; i < numbers.Length - 1; i++) {
                    Console.WriteLine ("     ------------------------------------");
                    ++w2;
                    Console.WriteLine ("     Loop 2, round: " + w2);

                    if (numbers[i] > numbers[i + 1]) {
                        Console.WriteLine ("          ************************");
                        ++w3;
                        Console.WriteLine ("          Replace found: " + w3 + " times");
                        Console.WriteLine ("          replacing " + numbers[i + 1] + " with " + numbers[i]);

                        var temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;

                        Console.WriteLine ("          ************************");
                        Console.WriteLine ("");

                        flag = false;

                    }

                    Console.WriteLine ("     ------------------------------------");
                    Console.WriteLine ("");

                }
                if (flag)
                    goto Res;

                Console.WriteLine ("###################################");
                Console.WriteLine ("");

            }
            Res:
                Console.WriteLine ("Results: ");

            foreach (var numb in numbers) {
                Console.WriteLine (numb);
            }

        }
    }
}