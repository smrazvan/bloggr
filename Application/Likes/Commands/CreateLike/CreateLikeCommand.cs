﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Likes.Commands.CreateLike
{
    public record class CreateLikeCommand(Like like) : IRequest<Like>;
}
