using MyPlaceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlaceRepositories.Interfaces
{
    public interface IPostRepository
    {
        void Create(Post post);
        void Delete(Post post);

        List<Post> GetAllPosts();

        List<Post> GetAllNotPrivate();
        Post GetById(int id);

        void UpdatePost(Post the_post);
        List<Post> FilteredByEmail(string email);
    }
}
