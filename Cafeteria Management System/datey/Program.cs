using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace datey
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder build = new StringBuilder();
            //build.Append(RandomSample.RandomString(6, true));
            //build.Append(RandomNumber.RandomNumGen(20, 40));
            //build.Append(RandomSample.RandomString(3, false));
            //Console.WriteLine(build);

            Console.WriteLine(RandomChoose.RandomPassword());
            Console.ReadLine();
        }
    }

  public class RandomNumber
    {
        
        public static  int RandomNumGen(int Min, int Max)
        {
            Random random = new Random();
            int RandomRes = random.Next(Min, Max);
            return RandomRes;
        }

    }
   

    public class RandomSample
    {

        public static string RandomString(int size, bool lowercase )
        {
            StringBuilder builder = new StringBuilder();


            Random random = new Random();
           

            for (int i=0; i<size; i++)
            {
              char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
              
              
            }
            if (lowercase)
            
               return  builder.ToString().ToLower();

            
            return builder.ToString();

          
        }

    }

    public class RandomChoose
    {

        public static string RandomPassword(int size =15)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string pass = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz%@#&";

            char[] chars = new char[size];
            for (int i=0; i<size; i++)
            {
                chars[i] = pass[random.Next(0,pass.Length)];


            }
            return new string(chars);

        }

        public static string RandomPasswordrand()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string pass = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz%@#&";
            int bass = random.Next(0, pass.Length);
            char[] chars = new char[bass];
            for (int i = 0; i < bass; i++)
            {
                chars[i] = pass[random.Next(0, pass.Length)];


            }
            return new string(chars);

        }

    }

}
