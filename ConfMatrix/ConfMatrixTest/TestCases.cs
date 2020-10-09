using NUnit.Framework;
using ConfMatrix;

namespace ConfMatrixTest
{
    public class TestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArgsAllZero()
        {
            Calc c = new Calc("0","0","0","0");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p,0);
            Assert.AreEqual(s, 0);
            Assert.AreEqual(sp, 0);
            Assert.AreEqual(f, 0);
            Assert.AreEqual(a, 0);
        }

        [Test]
        public void TwoArgsZero()
        {
            Calc c = new Calc("0", "5", "9", "0");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, 0);
            Assert.AreEqual(s, 0);
            Assert.AreEqual(sp, 0);
            Assert.AreEqual(f, 0);
            Assert.AreEqual(a, 0);
        }

        [Test]
        public void ArgsAllEmptyStr()
        {
            Calc c = new Calc("", "", "", "");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, 0);
            Assert.AreEqual(s, 0);
            Assert.AreEqual(sp, 0);
            Assert.AreEqual(f, 0);
            Assert.AreEqual(a, 0);
        }

        [Test]
        public void TwoArgsEmptyStr()
        {
            Calc c = new Calc("", "", "5", "8");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, 0);
            Assert.AreEqual(s, 0);
            Assert.AreEqual(sp, 0);
            Assert.AreEqual(f, 0);
            Assert.AreEqual(a, 0);
        }

        [Test]
        public void ArgsAllChar()
        {
            Calc c = new Calc("e", "w", "A", "Y");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, -1);
            Assert.AreEqual(s, -1);
            Assert.AreEqual(sp, -1);
            Assert.AreEqual(f, -1);
            Assert.AreEqual(a, -1);
        }

        [Test]
        public void ArgsAllValidNum()
        {
            Calc c = new Calc("5", "6", "12", "9");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, 0.454545468f);
            Assert.AreEqual(s, 0.357142866f);
            Assert.AreEqual(sp, 0.6666667f);
            Assert.AreEqual(f, 0.4f);
            Assert.AreEqual(a, 0.53125f);
        }



        // Failed cases

        [Test]
        public void ArgsAllPunctuationMarkSymbols()
        {
            Calc c = new Calc(".", ",", ";", "'");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, -1);
            Assert.AreEqual(s, -1);
            Assert.AreEqual(sp, -1);
            Assert.AreEqual(f, -1);
            Assert.AreEqual(a, -1);
        }

        [Test]
        public void ArgsTooBigNumbers()
        {
            Calc c = new Calc("35468486432545345345", "34347364", "354387684", "3543545");
            float p = c.precision();
            float s = c.sensitivity();
            float sp = c.specificity();
            float f = c.f1Score();
            float a = c.accuracy();
            Assert.AreEqual(p, -1);
            Assert.AreEqual(s, -1);
            Assert.AreEqual(sp, -1);
            Assert.AreEqual(f, -1);
            Assert.AreEqual(a, -1);
        }
    }
}