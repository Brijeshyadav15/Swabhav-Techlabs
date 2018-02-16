using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookmarksMVC_App.ViewModel
{
    public class IndexViewModel
    {
        [Required]
        public string Username
        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }

    }
}