using MyPlaceModels;
using MyPlaceRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPlaceRepositories
{
    public class PostRepository : IPostRepository
    {
        private readonly MyPlaceDbContext _dbContext;

        public PostRepository(MyPlaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create Post
        public void Create(Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
        }

        // Delete Post

        public void Delete(Post post)
        {
            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }

        // List of all posts
        public List<Post> GetAllPosts()
        {
            return _dbContext.Posts.OrderByDescending(x => x.DateCreated).ToList();
        }

        // List of all posts
        public List<Post> GetAllNotPrivate()
        {
            return _dbContext.Posts.OrderByDescending(x => x.DateCreated).Where(x => x.IsPrivate == false).ToList();
        }

        // Get by ID
        public Post GetById(int id)
        {
            return _dbContext.Posts.FirstOrDefault(x => x.Id == id);
        }


        // Update Post
        public void UpdatePost(Post the_post)
        {
            _dbContext.Posts.Update(the_post);
            _dbContext.SaveChanges();
        }
    }

}
