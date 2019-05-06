using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var rollvallist = new List<int>();
            Random r = new Random();
            int rollval = 0;
            int dicenum = 1;
            int examineturn = 1;
            float rollaverage = 0;
            int avcount = 1;
            int rolltotal = 0;
            int tcount = 1;
            int faces = 6;
            int lcount = 0;
            int examine = 0;
            int rollnum = 1;
            int turnnum = 1;
            string input;
            Console.WriteLine("how many faces do you want your dice to have?");
            faces = int.Parse(Console.ReadLine())+1;
            Console.WriteLine("how many dice do you want to use?");
            dicenum = int.Parse(Console.ReadLine())+1;
            while (turnnum == 1) 
            {
               
                Console.WriteLine("do you want to roll?");
                input = Console.ReadLine();
                if(input == "yes")
                {
                    while(rollnum < dicenum)
                    {
                        rollval = r.Next(1, faces);
                        Console.WriteLine(rollval);
                        rollvallist.Add(rollval);
                        rollnum = rollnum + 1;
                    }
                    rollnum = 1;
                }
                if (input == "no")
                {
                    turnnum = 2;
                    Console.WriteLine("how many rolls would you like to examine");
                    examine = int.Parse(Console.ReadLine());
                    Console.WriteLine("what would you like to do now?");
                    while (examineturn == 1)
                    {
                        input = Console.ReadLine();
                        if (input == "no")
                        {
                            examineturn = 2;
                        }
                        if (input == "average")
                        {
                            examine = examine - 1;
                            rolltotal = 0;
                            rollaverage = 0;
                            avcount = 0;
                            while (avcount <= examine)
                            {
                                rolltotal = rolltotal + rollvallist[avcount];
                                avcount = avcount + 1;
                                rollaverage = rolltotal / examine;
                            }
                            Console.WriteLine("the average is " + rollaverage);
                            avcount = 0;
                            examine = examine + 1;
                        }
                        if (input == "total")
                        {
                            rolltotal = 0;
                            tcount = 0;
                            while (tcount < examine)
                            {
                                rolltotal = (rolltotal + rollvallist[tcount]);
                                tcount = tcount + 1;
                            }
                            tcount = 1;
                            Console.WriteLine("the total is " + rolltotal + ".");

                        }
                        if (input == "list")
                        {
                            lcount = 0;
                            examine = examine - 1;
                            Console.Write("[");
                            while (lcount <= examine)
                            {
                                Console.Write(rollvallist[lcount] + ", ");
                                lcount = lcount + 1;
                            }
                            Console.Write("]");
                            lcount = 0;
                            examine = examine + 1;
                        }
                        Console.WriteLine("anything else?");
                    }
                    
                }
               
            }
            Console.ReadKey();
        }
    }
}
