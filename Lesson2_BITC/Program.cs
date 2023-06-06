using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = null;
            //s.ToString(); //NullReferenceException
            //Convert.ToString(s); //Բացառություն չկա

            string ss = "Armen";
            //int.Parse(ss); //FormatException
            bool t = int.TryParse(ss, out int k); //t => false; Բացառություն չկա 

            //const int a = 7000, b = 64, c = 2048, d = -50;

            //if (a > b)
            //    Console.WriteLine(a);
            //else if (a > c)
            //    Console.WriteLine(a);
            //else if (a > d)
            //    Console.WriteLine(a);
            //else
            //    Console.WriteLine("a-n poqr e boloric");

            //switch (a)
            //{
            //    case > c:
            //        Console.WriteLine(a);
            //        break;
            //    case > b:
            //        Console.WriteLine(a);
            //        break;
            //    case > d:
            //        Console.WriteLine(a);
            //        break;
            //    default:
            //        Console.WriteLine("a-n poqr e boloric");
            //        break;
            //}

            var usanox = new
            {
                id = 1,
                anun = "Armen",
                xumb = 912,
                mijin_gnahatakan = 9.6
            }; //anonymous type

            //Console.WriteLine(usanox.GetType());//<>f__AnonymousType0`4[System.Int32,System.String,System.Int32,System.Double]

            //usanox.anun = "Artur"; //readonly, poxvel chi karox

            //dynamic a; //runtime
            //a = 50;
            //Console.WriteLine(a.GetType());

            //a = "Armen";
            //Console.WriteLine(a.GetType());

            //a = 9.9;
            //Console.WriteLine(a.GetType());

            //double d = a;
            //int dd = (int)d; //explicit casting
            //Console.WriteLine(dd);
            //Console.WriteLine(d);

            //a = DateTime.Now;
            //Console.WriteLine(a.GetType());

            //int q = 45658;
            //long qq = q; //implicit casting
            //Console.WriteLine(qq);

            //byte a = 45, b = 46;
            //byte max = a > b ? a : b;
            //Console.WriteLine($"a = {a}\tb = {b}\tmax = {max}");

            //a++;
            //++a;
            //b--;
            //--b;
            //max = a > b ? a : b;
            //Console.WriteLine($"a = {a}\tb = {b}\tmax = {max}");

            Console.WriteLine(DateTime.Now.Millisecond);
            string s = "Armen";
            s += " ";
            s += "Mkhoyan";
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine(s + "\n");

            Console.WriteLine(DateTime.Now.Millisecond);
            StringBuilder sb = new StringBuilder();
            sb.Append("Armen");
            sb.Append(" ");
            sb.Append("Mkhoyan");
            Console.WriteLine(DateTime.Now.Millisecond);

            Console.WriteLine(sb);
        }
    }
}
