using MyPlaceModels;
using MyPlaceRepositories.Interfaces;
using MyPlaceServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlaceServices
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postsRepository;

        public PostService(IPostRepository postRepository)
        {
            _postsRepository = postRepository;
        }


        // Create Post
        public void Create(Post post, string userEmail)
        {
            if(post != null)
            {
                post.Email = userEmail;
                post.DateCreated = DateTime.UtcNow;
                _postsRepository.Create(post);
            }
        }

        // Delete Post
        public void Delete(int id)
        {
            var post = _postsRepository.GetById(id);

            if(post != null)
            {
                _postsRepository.Delete(post);
            }
        }

        // Get ALL POSTS
        public List<Post> GetByAll()
        {
            return _postsRepository.GetAllPosts();
        }

        public List<Post> GetAllNotPrivate()
        {
            return _postsRepository.GetAllNotPrivate();
        }

        // Get Post By Id
        public Post GetById(int id)
        {
            return _postsRepository.GetById(id);
        }

        // GetDetails
        public Post GetDetails(int id)
        {
            return _postsRepository.GetById(id);
        }


        // Update Post

        public void UpdatePost(Post post)
        {
            var the_post = _postsRepository.GetById(post.Id);
            if(the_post != null)
            {
                the_post.ImageUrl = post.ImageUrl;
                the_post.IsPrivate = post.IsPrivate;
                the_post.DateUpdated = DateTime.Now;
                _postsRepository.UpdatePost(the_post);
            }
        }

        // Search

        public List<Post> GetPostsByEmail(string email)
        {
            if(email == null)
            {
                return _postsRepository.GetAllNotPrivate();
            }
            else
            {
                return _postsRepository.FilteredByEmail(email);
            }
        }

    }
}
