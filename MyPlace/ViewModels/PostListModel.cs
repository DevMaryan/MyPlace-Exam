using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModels
{
    public class PostListModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrivate { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}
