using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Delegate__Exceptions_Practices
{
    internal class PracticeDelegate
    {
        #region Predicate


        //public delegate bool CheckNums(int num);


        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}

        ////public bool CheckNumByEven(int number) => number % 2 == 0;

        ////public bool CheckNumThanFive(int number) => number > 5;



        //public void CheckDelegate()
        //{
        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };

        //    nums.FindAll(CheckNumByOdd).Sum(m => m);

        //    Console.WriteLine(SumOfLIstItems(m => m > 5, nums));
        //}




        //public int SumOfLIstItems(Predicate<int> func,List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion


        #region Action


        //public delegate void ChangeString(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}
        //public void StringToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}

        //public void CheckWord()
        //{
        //ShowWord(StringToUpper,"Cavid");
        //ShowWord(StringToLower, "Cavid");
        //ChangeString changeString = StringToUpper;

        //changeString += StringToLower;
        //changeString +=  (string str) => Console.WriteLine(str.ToLower());

        //changeString("Pervin");

        //    Action<string> action = StringToUpper;
        //    action += (string str) => Console.WriteLine(str.ToLower());
        //    action("Pervin");
        //}

        //public void ShowWord(ChangeString func,string str)
        //{
        //    func(str);
        //}
        #endregion


        //public delegate int CheckString(string str,int age);

        public int GetStringLength(string word,int num)
        {
            return word.Length + num ;
        } 

        public void ShowStringLength(Func<string,int,int> func,string txt)
        {
            Console.WriteLine(func(txt,10));
        }

        public void ShowString()
        {
            ShowStringLength(GetStringLength,"Cavid");
        }
    }
}
