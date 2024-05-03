namespace Course.Interfaces
{
    interface IOnlinePaymentService
    {

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}