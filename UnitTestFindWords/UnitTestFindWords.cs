using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestWork;

namespace UnitTestFindWords
{
    [TestClass]
    public class UnitTestFindWords
    {
        [TestMethod]
        public void pos_find_words_return_mama_amam()
        {
            string str1 = "mama";
            string str2 = "amam";
            string commonStr = $"{str1} {str2}";
            string expected = $"Слова {str1} и {str2} обратимы." + '\n';

            Form1 f = new Form1();

            string actual = f.FindWords(commonStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void pos_find_words_return_papa_apap_mama_amam()
        {
            string commonStr = "my papa not apap, and my mama not amam!";
            string expected = "Слова papa и apap обратимы." + '\n' + "Слова mama и amam обратимы." + '\n';

            Form1 f = new Form1();

            string actual = f.FindWords(commonStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void neg_find_words_return_mama_amam()
        {
            string commonStr = "my papa not apap, and my mama not amam!";
            string expected = "Слова papap и apap обратимы." + '\n' + "Слова mama и amam обратимы." + '\n';

            Form1 f = new Form1();

            string actual = f.FindWords(commonStr);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void pos_find_words_return_mama_amam_top_pot()
        {
            string commonStr = "mama, amam, mama, amam, mama, top, top, pot";
            string expected = "Слова mama и amam обратимы." + '\n' + "Слова top и pot обратимы." + '\n';

            Form1 f = new Form1();

            string actual = f.FindWords(commonStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void neg_find_words_return_mama_amam_top_pot()
        {
            string commonStr = "mama, amam, mama, amam, mama, top, top, pot";
            string expected = "Слова mama и amam обратимы." + '\n' + "Слова mama и amam обратимы." + '\n' + "Слова amam и mama обратимы." + '\n' + "Слова top и pot обратимы." + '\n' + "Слова pot и top обратимы." + '\n';

            Form1 f = new Form1();

            string actual = f.FindWords(commonStr);

            Assert.AreNotEqual(expected, actual);
        }
    }
}
