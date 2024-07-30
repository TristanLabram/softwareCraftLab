using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator MyCalc;

        [SetUp]
        public void CreateCalculator()
        {
          this.MyCalc = new Calculator();
        }

        [Test]
        public void Subtract_validInputs_positiveOutput()
        {
          Assert.AreEqual(2, MyCalc.Subtract("5,3"));        
        }

    [Test]
    public void Subtract_InvalidInputs_ReturnsNegative9999()
    {
      Assert.AreEqual(-9999, MyCalc.Subtract("a,f"));
    }
    [Test]
    public void Multiply_ValidInputs_positiveOutput()
    {
      Assert.AreEqual(20, MyCalc.Multiply("2,10"));
    }

    [Test]
    public void Divide_ValidInputs_positiveOutput() 
    {
      Assert.AreEqual(2, MyCalc.Divide("21,10"));
    }
    
    [Test]
    public void Divide_InvalidInputs_ReturnsNegative9999()
    {
      Assert.Throws<DivideByZeroException>(() => MyCalc.Divide("3,0"));    
    }
    }
}
