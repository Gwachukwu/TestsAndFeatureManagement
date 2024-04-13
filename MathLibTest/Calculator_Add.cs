namespace MathLibTest;

using MathLib;

[TestClass]
public class Calculator_Add
{
    [TestMethod]
    public void Calculator_Add_Method_Receives_Two_Zeros_Returns_Zero()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Add(0, 0);
        Assert.AreEqual(0, ret);
    }
    [TestMethod]
    public void Calculator_Add_Method_Receives_A_One_And_Zero_Returns_One()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Add(1, 0);
        Assert.AreEqual(1, ret);
    }
}