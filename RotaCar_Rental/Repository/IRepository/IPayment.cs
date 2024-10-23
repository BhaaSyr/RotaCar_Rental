namespace RotaCar_Rental.Repository.IRepository
{
    public interface IPayment : IRepository<Payment>
    {
        void Update(Payment obj);
    }
}
