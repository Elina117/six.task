using System;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

namespace SixTaskDraft
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //File '1 2 3 4 5'
            //string a = fopen('1.txt');

            //Pour i = new Pour(a[4], a[1], a[2], a[3], a[0]);

            //answer = pour.printdidntused();

            //writeline(answer);


            //string path = "/Users/elinagalimova/Downloads/DeliveryProcess.txt";
            //FileStream f1 = File.OpenRead(path);

            StreamReader file1 = new StreamReader("/Users/elinagalimova/Downloads/DeliveryProcess.txt");
            string[] _array1 = file1.ReadToEnd().Split(",");
            int[] f1 = _array1.Select(int.Parse).ToArray();


            DeliveryProcess delivery = new DeliveryProcess(f1[0], f1[1], f1[2], f1[3], f1[4], f1[5]);

            double answer1 = delivery.printplace();
            double answer2 = delivery.printtime();
            double answer3 = delivery.printpayment();
            double answer4 = delivery.printsalary();
            double answer5 = delivery.printtimeforlunch();

            Console.WriteLine($"{answer1}, {answer2}, {answer2}, {answer2}, {answer2}");







            StreamReader file2 = new StreamReader("/Users/elinagalimova/Downloads/Boiling.txt");
            string[] _array2 = file2.ReadToEnd().Split(",");
            int[] f2 = _array2.Select(int.Parse).ToArray();

            Boiling boil = new Boiling(f2[0], f2[1], f2[2], f2[3], f2[4]);

            double result1 = boil.printneedtemp();
            double result2 = boil.printneedtime();
            double result3 = boil.printvolume();
            double result4 = boil.printnumberofbatches();
            double result5 = boil.printcoolingdown();

            Console.WriteLine($"{result1}, {result2}, {result3}, {result4}, {result5}");






            StreamReader file3 = new StreamReader("/Users/elinagalimova/Downloads/Pour.txt");
            string[] _array3 = file3.ReadToEnd().Split(",");
            int[] f3 = _array3.Select(int.Parse).ToArray();

            Pour pour = new Pour(f3[0], f3[1], f3[2], f3[3], f3[4]);

            double output1 = pour.printnumberbottle();
            double output2 = pour.printdidntused();
            double output3 = pour.printdefective();
            double output4 = pour.printdrinked();
            double output5 = pour.printtimeforpour();

            Console.WriteLine($"{output1}, {output2}, {output3}, {output4}, {output5}");






            StreamReader file4 = new StreamReader("/Users/elinagalimova/Downloads/Sale.txt");
            string[] _array4 = file4.ReadToEnd().Split(",");
            int[] f4 = _array4.Select(int.Parse).ToArray();

            Sale products = new Sale(f4[0], f4[1], f4[2], f4[3], f4[4]);

            double outcome1 = products.printprice();
            double outcome2 = products.salesontheday();
            double outcome3 = products.printvolume();
            double outcome4 = products.printnumberofpeople();
            double outcome5 = products.printprofit();

            Console.WriteLine($"{outcome1}, {outcome2}, {outcome3} , {outcome4}, {outcome5}");

        }


    }
}

