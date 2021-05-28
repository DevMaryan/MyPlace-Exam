using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModels
{
    public class PostUpdateModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrivate { get; set; }

    }
}
