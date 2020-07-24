using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// 单例模式
    /// Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
    /// </summary>
    public class Singleton
    {
        #region 饿汉式
        /// <summary>
        /// 饿汉式，类加载时，静态类就已经创建并初始化；不支持延迟加载。线程安全
        /// </summary>
        public static readonly Singleton Instance = new Singleton();
        private static object obj = new object();
        private Singleton()
        {

        }
        #endregion

        #region 懒汉式
        private static Singleton _lazyInstance;

        private int i = 0;
        /// <summary>
        /// 懒汉式实现了延迟加载，但是我们加了一把锁，频繁加锁和释放锁会导致性能瓶颈
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            lock (Instance)//不加锁会导致线程不安全
            {
                return _lazyInstance ??= new Singleton();
            }
        }

        public void Dod(Action<int> dod)
        {
            dod.Invoke(i++);
        }
        #endregion


        #region 双重检测
        private static Singleton _instance;
        /// <summary>
        /// 双重检查，解决了饿汉不支持延迟加载，懒汉式不支持高并发的问题
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton2()
        {
            if (_instance == null)
            {
                lock (obj)//不加锁会导致线程不安全
                {
                    return _instance ??= new Singleton();
                }
            }

            return _instance;
        }
        #endregion
    }

    class Start
    {
        static void Main(string[] args)
        {
            int threadIndex = 0;
            List<int> list = new List<int>();
            List<Task> tasks = new List<Task>();
            while (threadIndex < 200)
            {
                int index1 = threadIndex;
                var task = Task.Run(() =>
                    {
                        var single = Singleton.GetSingleton();
                        single.Dod(i =>
                        {
                            Console.WriteLine($"threadIndex:{index1}, singleI:{i}");
                            list.Add(i);
                        });

                    }
                );
                tasks.Add(task);
                threadIndex++;
            }

            Task.WaitAll(tasks.ToArray());
            var count = list.Distinct().Count();
            var number = list.GroupBy(i => i);
            foreach (IGrouping<int, int> grouping in number)
            {
                if (grouping.Count() > 1)
                {
                    Console.WriteLine(grouping.Key);
                }
            }
        }
    }
}
