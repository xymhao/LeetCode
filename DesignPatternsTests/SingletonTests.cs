using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestClass()]
    public class SingletonTests
    {
        [TestMethod()]
        public void DodTest()
        {
            int threadIndex = 0;
            while (threadIndex < 100)
            {
                int index1 = threadIndex;
                Task.Run(() =>
                    {
                        var single = Singleton.GetSingleton();
                        single.Dod(i =>
                        {
                            Console.WriteLine($"threadIndex:{index1}, singleI:{i}");
                        });
                    }
                    );

                threadIndex++;
            }
        }
    }
}