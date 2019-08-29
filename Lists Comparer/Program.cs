using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Comparer
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var list1 = File.ReadLines(Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        "list1.txt"));

            var list2 = File.ReadLines(Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        "list2.txt"));

            List<string> firstList = list1.ToList();
          
            for (int i = 0; i < firstList.Count; i++)
            {
                string deger = firstList[i].ToString();

                if (Search(deger))
                {
                    File.AppendAllText(Path.Combine(
       Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
       "result.txt"), firstList[i] + Environment.NewLine);
                    Console.WriteLine(firstList[i]);
                   
                }

                if(i == firstList.Count-1)
                    Console.ReadLine();
            }
        }

        public static bool Search(string word)
        {
            bool rtr = false;
            var list2 = File.ReadLines(Path.Combine(
       Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
       "list2.txt"));

            List<string> secondList = list2.ToList();
            for (int i = 0; i < secondList.Count; i++)
            {
                if (secondList[i].Trim() == word.Trim())
                {
                    rtr = false;
                    break;
                }
                else
                    rtr = true;
            }
            return rtr;
        }
    }
}
