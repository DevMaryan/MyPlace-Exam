using MyPlaceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlaceServices.Interfaces
{
    public interface IPostService
    {
        void Create(Post post, string userEmail);
        Post GetById(int id);
        void Delete(int id);

        void UpdatePost(Post post);
        List<Post> GetByAll();

        List<Post> GetAllNotPrivate();

        Post GetDetails(int id);
        List<Post> GetPostsByEmail(string email);
    }
}
