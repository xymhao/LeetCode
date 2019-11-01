using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LeetCode
{

    class Program
    {

        public class User
        {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public DateTime CreateTime { get; set; }
        }
        public class Person
        {
            private string firtstName;

            public string FirstName
            {
                get => firtstName;
                set => this.firtstName = value ?? "";
            }
            public string LastName { get; set; }

            public string FullName => $"{FirstName} {LastName}";
        }

        public class Animal
        {
            private string firtstName;

            public string FirstName
            {
                get => firtstName;
                set => this.firtstName = value ?? "";
            }
            public string LastName { get; set; }

            public string FullName => $"{FirstName} {LastName}";
        }
        // Covariant delegate.
        public delegate R DCovariant<out R>();

        // Methods that match the delegate signature.
        public static Person SampleControl()
        { return new Person(); }

        public static Animal SampleButton()
        { return new Animal(); }

        public void Test()
        {
            // Instantiate the delegates with the methods.
            DCovariant<Person> dControl = SampleControl;
            DCovariant<Animal> dButton = SampleButton;

            // You can assign dButton to dControl
            // because the DCovariant delegate is covariant.
            //dControl = dButton;

            // Invoke the delegate.
            dControl();
        }



        //static void Main(string[] args)
        //{
        //    Print(GetClassPropertiesName<User>(p => p.Name));
        //    Print(GetClassPropertiesName<User>(p => p));
        //    Print(GetClassPropertiesName<User>(p => new { p.Id, p.Name }));
        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            ConsoleColor colorBack = Console.BackgroundColor;
            ConsoleColor colorFore = Console.ForegroundColor;
            //1
            //2
            //合并提交
            //Console.SetCursorPosition(0, 0);
            Console.WriteLine("Loading...");

            int count = 0;
            int index = 0;
            double prePercent = 0;

            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            count = list.Count;
            //Console.SetCursorPosition(0, 1);
            //Console.WriteLine("Total:" + count);
            //count = 0;
            System.Threading.Thread.Sleep(5000);//模拟加载等待
            if (count > 0)
            {
                //Console.SetCursorPosition(0, 1);
                Console.WriteLine("Total:" + count);
                //绘制界面
                Console.WriteLine("********************* Loading *********************");
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                for (int i = 0; ++i <= 50;)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
                Console.BackgroundColor = colorBack;
                Console.WriteLine("0%");
                Console.WriteLine("***************************************************");

                foreach (string str in list)
                {
                    #region 绘制界面
                    //绘制界面
                    index++;
                    double percent;
                    if (index <= count)
                    {
                        percent = (double)index / count;
                        percent = Math.Ceiling(percent * 100);
                    }
                    else
                    {
                        percent = 1;
                        percent = Math.Ceiling(percent * 100);
                    }
                    // 开始控制进度条和进度变化
                    for (int i = Convert.ToInt32(prePercent); i <= percent; i++)
                    {
                        //绘制进度条进度
                        Console.BackgroundColor = ConsoleColor.Yellow;//设置进度条颜色
                        Console.SetCursorPosition(i / 2, 3);//设置光标位置,参数为第几列和第几行
                        Console.Write(" ");//移动进度条
                        Console.BackgroundColor = colorBack;//恢复输出颜色
                        //更新进度百分比,原理同上.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 4);
                        Console.Write("{0}%", i);
                        Console.ForegroundColor = colorFore;
                        //模拟实际工作中的延迟,否则进度太快
                        System.Threading.Thread.Sleep(50);
                    }
                    prePercent = percent;
                    #endregion
                }

                Console.SetCursorPosition(0, 6);

                Console.WriteLine("Loading Complete.");
            }
            Console.ReadLine();//会等待直到用户按下回车，一次读入一行
        }
        static void Print(List<string> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static List<string> GetClassPropertiesName<T>(Expression<Func<T, dynamic>> select)
        {
            var result = new List<string>();
            var body = select.Body;
            if (body.NodeType == ExpressionType.Parameter)
            {
                result.AddRange((body as ParameterExpression).Type.GetProperties().Select(p => p.Name));
            }
            else if (body.NodeType == ExpressionType.MemberAccess)
            {
                result.Add((body as MemberExpression).Member.Name);
            }
            else if (body.NodeType == ExpressionType.New)
            {
                result.AddRange((body as NewExpression).Members.Select(p => p.Name));
            }
            return result;
        }
        public static void Funtest(Action<int> fc)
        {
            for (var i = 0; i < 5; i++)
            {
                fc.Invoke(i);
            }
        }
        public static IEnumerable<int> Power(int number)
        {
            int result = 1;
            for (int i = 1; i < number; i++)
            {
                result = i * result;
                yield return i * result;
            }
        }

        public static (string str, int intval, bool boolValue) UseTuple()
        {
            return ("0", 1, true);
        }

        public static IEnumerable<char> AlphabetSubset3(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }

        /// <summary>
        /// 本地函数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LocalFunctionFactorial(int n)
        {
            return nthFactorial(n);

            int nthFactorial(int number) => (number < 2) ?
                1 : number * nthFactorial(number - 1);
        }

        public static int LambdaFactorial(int n)
        {
            Func<int, int> nthFactorial = default(Func<int, int>);

            nthFactorial = (number) => (number < 2) ?
                1 : number * nthFactorial(number - 1);

            return nthFactorial(n);
        }
        //public int[] Intersect(int[] nums1, int[] nums2)
        //{
        //    Dictionary<int, int> dict = new Dictionary<int, int>();
        //    for (var i = 0; i < nums1.Length; i++)
        //    {
        //        for (var j = 0; j < nums2.Length; j++)
        //        {

        //        }
        //    }
        //}
        public static ref int Find3(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }


        public static int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.TryGetValue(nums[i], out int val))
                {
                    dict[nums[i]] = val;
                }
            }
            int j = 0;
            foreach (var d in dict)
            {
                nums[j] = d.Key;
                j++;
            }
            return dict.Count;
        }

        public static int MaxProfit(int[] prices)
        {
            int money = 0;
            for (var i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    money = money + prices[i + 1] - prices[i];
                }
            }
            return money;
        }
        public static void Rotate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] backupNums = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var index = i + k >= nums.Length ? (i + k) % nums.Length : i + k;
                backupNums[index] = nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = backupNums[i];
            }
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int val))
                {
                    return true;
                }
                else
                {
                    dict[nums[i]] = 0;
                }
            }
            return false;
        }

        public static int SingleNumber(int[] nums)
        {
            int res = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            return res;
        }

    }

    internal class Student
    {
        public Student(string althea, string goodwin)
        {
            
        }
    }
}
