using MyPlace.ViewModels;
using MyPlaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Mappings
{
    public static class ViewModelExtensions
    {
        public static Post ToModel(this PostCreateModel viewModel)
        {
            return new Post
            {
                ImageUrl = viewModel.ImageUrl,
                IsPrivate = viewModel.IsPrivate,
                Email = viewModel.Email,
            };
        }
        public static Post ToModel(this PostUpdateModel viewModel)
        {
            return new Post
            {
                Id = viewModel.Id,
                ImageUrl = viewModel.ImageUrl,
                Email = viewModel.Email,
                IsPrivate = viewModel.IsPrivate,
            };
        }


    }
}
