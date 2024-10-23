

namespace RotaCar_Rental.Repository.IRepository
{
    public interface IReview : IRepository<Review>
    {
        void Update(Review obj);
    }
}
