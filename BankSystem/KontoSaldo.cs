namespace BankSystem
{
  public class KontoSaldo
  {
    public int Konto(int konto, int saldo) => saldo != 0 ? konto / saldo : throw new NotFiniteNumberException("Inte dividera med noll!");
  }
}