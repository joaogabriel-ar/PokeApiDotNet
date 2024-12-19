using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        public Review GetReview(int reviewId);
        public ICollection<Review> GetReviewsOfPokemon(int pokeId);
        public ICollection<Review> GetReviewsOfReviewer(int reviewerId);
        public ICollection<Review> GetReviews();

        public Boolean ReviewExists(int id);
    }
}
