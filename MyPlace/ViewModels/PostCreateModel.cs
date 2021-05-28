using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModels
{
    public class PostCreateModel
    {
        public string ImageUrl { get; set; }
        public bool IsPrivate { get; set; }
        public string Email { get; set; }

    }
}
