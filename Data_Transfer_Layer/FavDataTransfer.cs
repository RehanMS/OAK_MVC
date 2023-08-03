﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Data_Transfer_Layer
{
    public class FavDataTransfer
    {
        public int FavID { get; set; }
        [Required(ErrorMessage ="Please enter Title")]
        public string Title { get; set; }
        public string Fav { get; set; }
        public string Logo { get; set; }
        [Display(Name ="Logo Image")]
        public HttpPostedFileBase LogoImage { get; set; }
        [Display(Name = "Fav Image")]
        public HttpPostedFileBase FavImage { get; set; }
    }
}
