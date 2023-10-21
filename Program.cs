using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        // выбери левел сложности / select difficulty level
        //static int[] DATA = { 1, 4, 7, 3, 6, 10, 2, 9, 5, 8};  
        static int[] DATA = { 61776 , 80635 , 69321 , 64873 , 72601 , 93667 , 75883 , 70807 , 83840 , 91654
                            ,80413, 21277, 53747, 51693, 93503, 41878, 91090, 22970, 91044, 40065, 45067};
                             

        static void Main(string[] args)
        {
            MiddleArreyAndSortAlgoritm();
            Console.ReadKey();

        }

        public static void MiddleArreyAndSortAlgoritm()
        {
            int ni = 0;
            int nif = 0;
            

            foreach (int DataForeach in DATA)
            {

                Console.WriteLine(DataForeach);
                ni++;
            }
            Console.WriteLine("-------------");
            Console.WriteLine(DATA[ni / 2] + " This Middle of the Arrey DATA - "
                                            + ni / 2 + 
                                            " middle index arrey\n--- SortAlgoritm method ---");
            int MiddleArrey = DATA[ni / 2];
            try
            {

                while (DATA[nif] != MiddleArrey) // придумай куда сохранять 
                {

                    if (DATA[nif] < MiddleArrey)
                    {
                        Console.WriteLine("NIF = " + nif);
                        Console.WriteLine(DATA[nif] + " < " + MiddleArrey);
                        ++nif;
                    }
                    if (DATA[nif] > MiddleArrey)
                    {
                        Console.WriteLine("NIF = " + nif);
                        Console.WriteLine(DATA[nif] + " > " + MiddleArrey);
                        ++nif;
                    }

                    if (DATA[nif] == MiddleArrey)
                    {
                        Console.WriteLine("NIF = " + nif);
                        Console.WriteLine(DATA[nif] + " == " + MiddleArrey);
                        ++nif;
                    }

                }
            }
            catch{}
            }
        }
    }

//  easy level 😊
//  1| 4| 7| 3| 6| 10| 2| 9| 5| 8| number
//  0| 1| 2| 3| 4| 5 | 6| 7| 8| 9| index

// hard level  💀
//61776| 80635| 69321| 64873| 72601| 93667| 75883| 70807| 83840| 91654|      |   number
//  0  |   1  |   2  |   3  |   4  |   5  |   6  |   7  |   8  |   9  |      |  index
//80413| 21277| 53747| 51693| 93503| 41878| 91090| 22970| 91044| 40065| 45067|  number 
// 10  |  11  |  12  |  13  |  14  |  15  | 16   |  17  |  18  |  19  |  20  |  index
//
/*
                     if (nif > 9)
                     {
                        Console.WriteLine("nif > DATA[MiddleArrey * 2]");
                        break;
                    }
*/