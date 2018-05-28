using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers2
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Enter the low number in your range");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the higher number in your range");
            int num2 = int.Parse(Console.ReadLine());
            int[] lotterynumbers = new int[6];




            Console.WriteLine("Please choose your first number");
            lotterynumbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your second number");
            lotterynumbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your third number");
            lotterynumbers[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your fourth number");
            lotterynumbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your fifth number");
            lotterynumbers[4] = int.Parse(Console.ReadLine());


            Console.WriteLine("Please choose your sixth number");
            lotterynumbers[5] = int.Parse(Console.ReadLine());

            Console.WriteLine("your numbers are {0}, {1},{2},{3},{4},{5}", lotterynumbers[0], lotterynumbers[1], lotterynumbers[2], lotterynumbers[3],
               lotterynumbers[4], lotterynumbers[5]);

            int[] Randnum = new int[6];
            Random r = new Random();
            for (int i = 0; i < Randnum.Length; i++)
            {
                Randnum[0] = r.Next(1, 100);
                Randnum[1] = r.Next(1, 100);
                Randnum[2] = r.Next(1, 100);
                Randnum[3] = r.Next(1, 100);
                Randnum[4] = r.Next(1, 100);
                Randnum[5] = r.Next(1, 100);
                Console.WriteLine("The winning numbers are {0}", Randnum[0], Randnum[1], Randnum[2],
                    Randnum[3], Randnum[4], Randnum[5]);
                if
                    (Randnum[0] == lotterynumbers[0])

                    Console.WriteLine("you win");
                else
                if
                     (Randnum[0] != lotterynumbers[0])
                    Console.WriteLine("You did not win"); 
                ///I am still working on the Project I have had a hard weekend also this pc keeps rebooting.
















            }

            
            

            
            










            {
                
           
                //lownumber = Console.ReadLine();

            }
              




           //for (int i= 0; i <firstnumber.Length; i++)
            {
                //Console.WriteLine(i);

            }

           


            

             


















        }
    }
}