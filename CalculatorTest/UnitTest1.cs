using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorCore;

namespace CalculatorTest {
    [TestClass]
    public class UnitTest1 {

#region Basic Calculation
        [TestMethod]
        public void BasicAddition() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            calculator.Input(InputType.Add);
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456).ToString());
        }

        [TestMethod]
        public void BasicSubtraction() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            calculator.Input(InputType.Sub);
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123 - 456).ToString());
        }

        [TestMethod]
        public void BasicMultiplication() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            calculator.Input(InputType.Mul);
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123 * 456).ToString());
        }

        [TestMethod]
        public void BasicDivision() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            calculator.Input(InputType.Div);
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123d / 456d).ToString());
        }

        [TestMethod]
        public void ZeroAtTheBeginning() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num0);
            Assert.AreEqual(calculator.DisplayValue, 0.ToString());
            calculator.Input(InputType.Num2);
            Assert.AreEqual(calculator.DisplayValue, 2.ToString());
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, 23.ToString());
            calculator.Input(InputType.Add);
            calculator.Input(InputType.Num00);
            Assert.AreEqual(calculator.DisplayValue, 0.ToString());
            calculator.Input(InputType.Num5);
            Assert.AreEqual(calculator.DisplayValue, 5.ToString());
            calculator.Input(InputType.Num6);
            Assert.AreEqual(calculator.DisplayValue, 56.ToString());
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (23 + 56).ToString());
        }

        [TestMethod]
        public void CalculationWithDot() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num0);
            Assert.AreEqual(calculator.DisplayValue, 0.ToString());
            calculator.Input(InputType.Num2);
            Assert.AreEqual(calculator.DisplayValue, 2.ToString());
            calculator.Input(InputType.Dot);
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, 2.3d.ToString());
            calculator.Input(InputType.Div);
            calculator.Input(InputType.Num00);
            Assert.AreEqual(calculator.DisplayValue, 0.ToString());
            calculator.Input(InputType.Dot);
            calculator.Input(InputType.Num5);
            Assert.AreEqual(calculator.DisplayValue, 0.5d.ToString());
            calculator.Input(InputType.Num6);
            Assert.AreEqual(calculator.DisplayValue, 0.56d.ToString());
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (2.3d / 0.56d).ToString());
        }

        #endregion

        [TestMethod]
        public void ContinuousPlus() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            calculator.Input(InputType.Add);
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Add);
            calculator.Input(InputType.Num7);
            calculator.Input(InputType.Num8);
            calculator.Input(InputType.Num9);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456 + 789).ToString());
        }

        [TestMethod]
        public void ContinuousOperators() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Add);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Sub);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456).ToString());
            calculator.Input(InputType.Num7);
            calculator.Input(InputType.Num8);
            calculator.Input(InputType.Num9);
            Assert.AreEqual(calculator.DisplayValue, (789).ToString());
            calculator.Input(InputType.Div);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456 - 789).ToString());
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (((double)(123 + 456 - 789)) / 123d).ToString());
        }

        [TestMethod]
        public void OperatorsAfterEqual() {
            CalculatorCore.CalculatorCore calculator = new CalculatorCore.CalculatorCore();
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Add);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Num4);
            calculator.Input(InputType.Num5);
            calculator.Input(InputType.Num6);
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456).ToString());
            calculator.Input(InputType.Div);
            Assert.AreEqual(calculator.DisplayValue, (123 + 456).ToString());
            calculator.Input(InputType.Num1);
            calculator.Input(InputType.Num2);
            calculator.Input(InputType.Num3);
            Assert.AreEqual(calculator.DisplayValue, (123).ToString());
            calculator.Input(InputType.Eq);
            Assert.AreEqual(calculator.DisplayValue, (((double)(123 + 456)) / 123d).ToString());
        }

    }
}
