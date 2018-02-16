using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookmarksMVC_App.ViewModel
{
    public class AddBookmarksViewModel
    {
        [Required]
        public string Name
        {
            get;
            set;
        }

        [Required]
        public string URL
        {
            get;
            set;
        }

    }
}