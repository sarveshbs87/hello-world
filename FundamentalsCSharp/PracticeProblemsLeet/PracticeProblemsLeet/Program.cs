using System.Text;

namespace PracticeProblemsLeet
{
    internal class Program
    {
        public string MergeStrings(string str1,string str2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0,j = 0;
            while(i < str1.Length && j < str2.Length)
            {
                sb.Append(str1[i++]);
                //i++;
                sb.Append(str2[j++]);
                //j++;
            } 
            if(i<str1.Length) sb.Append(str1.Substring(i));
            if(j<str2.Length) sb.Append(str2.Substring(j));

            return sb.ToString();

        }

        public static int GetAbsSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Math.Abs(arr[i]);
            }
            return sum;
        }

        public static long CalcExponent(long num,long expo)
        {
            double resultexpo = Math.Pow(num, expo);
            long resexp = Convert.ToInt64(resultexpo);
            return resexp;
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            int resarr;
            foreach (int item in arr)
            {
                resarr = item*arr.Length;
            }

            ToA

            return resarr.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program medp = new Program();
            //Console.WriteLine( medp.MergeStrings("abc", "pqrs"));
            //Console.WriteLine( GetAbsSum([2, -1, 4, 8, 10]));
            //Console.WriteLine(CalcExponent(3,5));
        }
    }
}
