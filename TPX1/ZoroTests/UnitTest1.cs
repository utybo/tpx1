using NUnit.Framework;

namespace ZoroTests
{   
    [TestFixture]
    public class PolynomialTest
    {
        [Test]
        public void ComputeCovidCasesTest0()
        {
            Assert.AreEqual(0.6f, Polynomial.Program.ComputeCovidCases(0f), 0.001f);
        }
        
        [Test]
        public void ComputeCovidCasesTest1()
        {
            Assert.AreEqual(0.278495f, Polynomial.Program.ComputeCovidCases(1f), 0.001f);
        }
        
        [Test]
        public void ComputeCovidCasesTest2()
        {
            Assert.AreEqual(2.31577f, Polynomial.Program.ComputeCovidCases(2f), 0.001f);
        }
        
        [Test]
        public void ComputeCovidCasesTest13()
        {
            Assert.AreEqual(9.37841f, Polynomial.Program.ComputeCovidCases(13f), 0.001f);
        }
        [Test]
        public void ComputeCovidCasesTest14()
        {
            Assert.AreEqual(4.8993f, Polynomial.Program.ComputeCovidCases(14f), 0.001f);
        }
        
        
        float[] coeffs = new[] { 0.6f, -2.133257f, 2.182121f, -0.399069f, 0.029503f, -0.000803f };
        
        [Test]
        public void ComputePolynomialTest0()
        {
            Assert.AreEqual(0.6f, Polynomial.Program.ComputePolynomial(0f, coeffs), 0.001f);
        }
        
        [Test]
        public void ComputePolynomialTest1()
        {
            Assert.AreEqual(0.278495f, Polynomial.Program.ComputePolynomial(1f, coeffs), 0.001f);
        }
        
        [Test]
        public void ComputePolynomialTest2()
        {
            Assert.AreEqual(2.31577f, Polynomial.Program.ComputePolynomial(2f, coeffs), 0.001f);
        }
        
        [Test]
        public void ComputePolynomialTest13()
        {
            Assert.AreEqual(9.37841f, Polynomial.Program.ComputePolynomial(13f, coeffs), 0.001f);
        }
        
        [Test]
        public void ComputePolynomialTest14()
        {
            Assert.AreEqual(4.8993f, Polynomial.Program.ComputePolynomial(14f, coeffs), 0.001f);
        }
    }

    [TestFixture]
    public class SortingTest
    {
        [Test]
        public void SlowSortTest1()
        {
            int[] arr = new[] {31, 65, 8, 91, 43, 9, 11, 53, 76};
            
            Sorting.Program.SlowSort(arr);
            
            Assert.AreEqual(true, Sorting.Program.Sorted(arr));
        }
        
        [Test]
        public void SlowSortTest2()
        {
            int[] arr = new[] {4568, -31, 6543, 8, 91, -4376, 967, 112, 534, 76975, 3298, 1367, -234, 984379};
            
            Sorting.Program.SlowSort(arr);
            
            Assert.AreEqual(true, Sorting.Program.Sorted(arr));
        }
        
        [Test]
        public void SlowSortTest3()
        {
            int[] arr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            Sorting.Program.SlowSort(arr);
            
            Assert.AreEqual(true, Sorting.Program.Sorted(arr));
        }
        
        [Test]
        public void SlowSortTest4()
        {
            int[] arr = new[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            
            Sorting.Program.SlowSort(arr);
            
            Assert.AreEqual(true, Sorting.Program.Sorted(arr));
        }
    }
}