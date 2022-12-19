﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Users.Queries.GetUsers
{
    public class UsersQueryDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Bio { get; set; }

        public DateTimeOffset BirthDate { get; set; }
    }
}
