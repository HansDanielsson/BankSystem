using BankSystem;

namespace BankTest
{
  [TestClass]
  public class BankTest
  {
    [TestMethod]
    public void TestMethod1()
    {
      KontoSaldo test = new KontoSaldo();
      Assert.AreEqual(1, test.Konto(1, 1));
    }

    [TestMethod]
    public void TestMethod2()
    {
      KontoSaldo test = new KontoSaldo();
      Assert.AreEqual(2, test.Konto(4, 2));
    }

    [TestMethod]
    [ExpectedException(typeof(NotFiniteNumberException), "Hejsan")]
    public void TestMethod3()
    {
      KontoSaldo test = new KontoSaldo();
      Assert.AreNotEqual(3, test.Konto(12, 0));
    }

    [TestMethod]
    [ExpectedException(typeof(NotFiniteNumberException), "Hejsan")]
    public void TestMethod4()
    {
      KontoSaldo test = new KontoSaldo();
      Assert.AreEqual(5, test.Konto(25, 0));
    }
  }
}