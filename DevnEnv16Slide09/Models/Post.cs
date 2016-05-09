using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevnEnv16Slide09.Models
{
    public class Post
    {
        private static int noPosts;

        [Display(Name ="ID")]
        public int PostId { get; set; }

     
        [Required ]
        public string Title { get; set; }

        [Display(Name = "Text")]
        [Required, StringLength(10, MinimumLength =3)]
        public string Body { get; set; }

        public Post()
        {
            noPosts++;
            this.PostId = noPosts;
        }
            
       
    }
}