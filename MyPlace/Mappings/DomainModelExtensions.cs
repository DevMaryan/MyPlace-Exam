using MyPlace.ViewModels;
using MyPlaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Mappings
{
    public static class DomainModelExtensions
    {
        public static PostListModel ToPostModel(this Post post)
        {
            return new PostListModel()
            {
                Id = post.Id,
                ImageUrl = post.ImageUrl,
                IsPrivate = post.IsPrivate,
                DateCreated = post.DateCreated,
                DateUpdated = post.DateUpdated,
            };
        }
        public static PostUpdateModel ToUpdateModel(this Post post)
        {
            return new PostUpdateModel()
            {
                ImageUrl = post.ImageUrl,
                IsPrivate = post.IsPrivate,
            };
        }
    }
}
