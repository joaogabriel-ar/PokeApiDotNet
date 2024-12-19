using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        public Reviewer GetReviewer(int reviewerId);
        public ICollection<Reviewer> GetReviewers();

        public ICollection<Review> GetReviewsOfReviewer(int reviewerId);

        public Boolean ReviewerExists(int reviewerId);
    }
}
