 

namespace Course.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get;  set; }

        public SavingsAccount()
        {

        } 
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        } 
        // reimplementamos na sub classe a operação que já existia na super classe. Assim dá um comportamento diferente e é aceita.
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); // com o base conseguimos reaproveitar a operação da supe classe e ainda posso acrescentar outras coisas.
            Balance -= 2.0;
        } 
    }
}
