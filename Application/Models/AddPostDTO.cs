﻿using Bloggr.Domain.Entities;

namespace Application.Models
{
    public class AddPostDTO
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Caption { get; set; }
    }
}