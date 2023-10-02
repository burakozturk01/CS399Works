﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateReview(Review review)
        {
            _context.Add(review);
            return Save();
        }

        public bool DeleteReview(Review review)
        {
            _context.Remove(review);
            return Save();
        }

        public bool DeleteReviews(List<Review> reviews)
        {
            _context.RemoveRange(reviews);
            return Save();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.OrderByDescending(r => r.Rating).ToList();
        }

        public ICollection<Review> GetReviewsByPokemon(int pokeId)
        {
            return _context.Reviews
                .Where(r => r.Pokemon.Id == pokeId)
                .OrderByDescending(r => r.Rating).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r  => r.Id == reviewId);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool UpdateReview(Review review)
        {
            _context.Update(review);
            return Save();
        }

        bool IReviewRepository.DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}