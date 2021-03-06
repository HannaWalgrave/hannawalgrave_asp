﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HannaWalgrave_aspcore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HannaWalgrave_aspcore.Models
{
    public class BookDetailViewModel
    {
        public string ISBN;
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        
    }
}