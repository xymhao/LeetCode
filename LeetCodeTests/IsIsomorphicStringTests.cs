using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class IsIsomorphicStringTests
    {
        [TestMethod]
        public void Should_a_And_a_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("a");
            Assert.IsTrue(oneIsomorphicString.Isomorphic("a"));
        }

        [TestMethod]
        public void Should_a_And_A_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("a");
            Assert.IsTrue(oneIsomorphicString.Isomorphic("A"));
        }

        [TestMethod]
        public void Should_a_And_bb_Not_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("a");
            Assert.IsFalse(oneIsomorphicString.Isomorphic("bb"));
        }

        [TestMethod]
        public void Should_aa_And_ab_Not_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("aa");
            Assert.IsFalse(oneIsomorphicString.Isomorphic("ab"));
        }

        [TestMethod]
        public void Should_Abb_And_bcc_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("Abb");
            Assert.IsTrue(oneIsomorphicString.Isomorphic("bcc"));
        }

        [TestMethod]
        public void Should_paper_And_title_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("paper");
            Assert.IsTrue(oneIsomorphicString.Isomorphic("title"));
        }

        [TestMethod]
        public void Should_Abb_And_bcd_Not_Be_IsomorphicString()
        {
            IsomorphicString oneIsomorphicString = new IsomorphicString("Abb");
            Assert.IsFalse(oneIsomorphicString.Isomorphic("bcd"));
        }
    }
}
