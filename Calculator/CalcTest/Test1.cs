using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CalcTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()//Basic Addition Test
        {
            double expectedResult = 8;
            double result = 4 + 4;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod2()//Addition Test2
        {
            double expectedResult = 20.5;
            double result = 10.3 + 10.2;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod3()//Subtraction
        {
            double expectedResult = 3.4;
            double result = 5.8 - 2.4;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod4()//Mod
        {
            double expectedResult = 3;
            double result = 10 % 7;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod5()//Mod Test2
        {
            double expectedResult = 17;
            double result = 17 % 111111;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod6()//Matrices Addition
        {
            double expectedResult1 = 8;
            double expectedResult2 = 10;
            double expectedResult3 = 12;
            double expectedResult4 = 14;
            double result1 = 2 + 6;
            double result2 = 3 + 7;
            double result3 = 4 + 8;
            double result4 = 5 + 9;
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
            Assert.AreEqual(expectedResult3, result3);
            Assert.AreEqual(expectedResult4, result4);
        }
        [TestMethod]
        public void TestMethod7()//Matrices Subtraction
        {
            double expectedResult1 = -4;
            double expectedResult2 = -4;
            double expectedResult3 = -4;
            double expectedResult4 = -4;
            double result1 = 2 - 6;
            double result2 = 3 - 7;
            double result3 = 4 - 8;
            double result4 = 5 - 9;
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
            Assert.AreEqual(expectedResult3, result3);
            Assert.AreEqual(expectedResult4, result4);
        }
        [TestMethod]
        public void TestMethod8()//addition with a negative
        {
            double expectedResult = 20;
            double result = 40 + -20;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod9()//subtraction with a negative
        {
            double expectedResult = 60;
            double result = 40 - -20;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod10()//sqrt
        {
            double expectedResult = 7;
            double result = Math.Sqrt(49);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod11()//Linear con
        {
            double expectedResult = 11;
            double result = (2 * 3 + 5) % 16;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod12()//mod by 10
        {
            double expectedResult = 9;
            double result = 108629 % 10;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod13()//determinant
        {
            double expectedResult = 20;
            double a = 8;
            double b = 5;
            double c = 4;
            double d = 5;
            double result = (a * d) - (b * c);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethod14()//Decryption n - 3
        {
            string expectedResult = "WOOF";
            string decrypt = "ZRRI";
            string encrypted = "";
            for (int i = 0; i < decrypt.Length; i++)
            {
                char oldLetter = decrypt[i];
                int num = oldLetter - 'A';
                int encrypt = (num - 3) % 26;
                char newLetter = (char)(encrypt + 'A');
                encrypted += newLetter;
            }
            Assert.AreEqual(expectedResult, encrypted);
        }
        [TestMethod]
        public void TestMethod15()//Encryption n + 3
        {
            string expectedResult = "ZRRI";
            string encrypt2 = "WOOF";
            string encrypted = "";
            for (int i = 0; i < encrypt2.Length; i++)
            {
                char oldLetter = encrypt2[i];
                int num = oldLetter - 'A';
                int encrypt = (num + 3) % 26;
                char newLetter = (char)(encrypt + 'A');
                encrypted += newLetter;
            }
            Assert.AreEqual(expectedResult, encrypted);
        }
        [TestMethod]
        public void TestMethod16()//Dec to BCD
        {
            string expectedResult = "10000000";
            int dec = 128;
            string binaryValue = Convert.ToString(dec, 2);
            while (binaryValue.Length < 8)
            {
                binaryValue = "0" + binaryValue;
            }
            Assert.AreEqual(expectedResult, binaryValue);
        }
        [TestMethod]
        public void TestMethod17()//Dec to HEX
        {
            string expectedResult = "F";
            int dec = 15;
            string hexValue = dec.ToString("X");
            Assert.AreEqual(expectedResult, hexValue);
        }
    }
}