using System;
using System.Collections.Generic;
namespace LeetCode
{

    class Program
    {


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



        static void Main(string[] args)
        {
            var classList = new Enrollment()
                          {
                              new Student("Lessie", "Crosby"),
                              new Student("Vicki", "Petty"),
                              new Student("Ofelia", "Hobbs"),
                              new Student("Leah", "Kinney"),
                              new Student("Alton", "Stoker"),
                              new Student("Luella", "Ferrell"),
                              new Student("Marcy", "Riggs"),
                              new Student("Ida", "Bean"),
                              new Student("Ollie", "Cottle"),
                              new Student("Tommy", "Broadnax"),
                              new Student("Jody", "Yates"),
                              new Student("Marguerite", "Dawson"),
                              new Student("Francisca", "Barnett"),
                              new Student("Arlene", "Velasquez"),
                              new Student("Jodi", "Green"),
                              new Student("Fran", "Mosley"),
                              new Student("Taylor", "Nesmith"),
                              new Student("Ernesto", "Greathouse"),
                              new Student("Margret", "Albert"),
                              new Student("Pansy", "House"),
                              new Student("Sharon", "Byrd"),
                              new Student("Keith", "Roldan"),
                              new Student("Martha", "Miranda"),
                              new Student("Kari", "Campos"),
                              new Student("Muriel", "Middleton"),
                              new Student("Georgette", "Jarvis"),
                              new Student("Pam", "Boyle"),
                              new Student("Deena", "Travis"),
                              new Student("Cary", "Totten"),
                              new Student("Althea", "Goodwin")
                          };
            var per = new Person
            {
                FirstName = "Xu"
            };
            per.FirstName = null;

            per.LastName = "Yue";
            Console.WriteLine(per.FullName);
            var tupe = UseTuple();

            Console.WriteLine($"{tupe.boolValue},{tupe.intval},{tupe.str}");

            var matrix = new int[,] { { 1, 2, 3 }, { 42, 5, 6 } };
            ref var valItem = ref Find3(matrix, (val) => val == 42);
            Console.WriteLine(valItem);
            valItem = 24;
            foreach (var x in Power(10))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(Power(10));

            Funtest(x =>
            {
                Console.WriteLine(x);
            });
            Console.Read();

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
}
