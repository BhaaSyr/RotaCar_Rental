namespace RotaCar_Rental.Repository.IRepository
{
    public interface IRental : IRepository<Rental>
    {
        void Update(Rental obj);
    }
}
