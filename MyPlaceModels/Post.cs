using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlaceModels
{
    public class Post
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}
