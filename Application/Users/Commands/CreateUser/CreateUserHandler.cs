﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Users.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUnitOfWork _UOW;

        public CreateUserHandler(IUnitOfWork UOW)
        {
            _UOW = UOW;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User result = await _UOW.Users.Add(request.user);
            await _UOW.Save();
            return result;
        }
    }
}