﻿using Common.Contracts.Repository.User;
using Common.Contracts.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    public class UserServices: IUserServices
    {
        #region ctor 
            private readonly IUserRepository _repository;
            public UserServices(IUserRepository repository)
            {
                _repository = repository;
            }
        #endregion

        #region crud for UserServices
            public async Task AddUserAsync() { }
            public async Task UpdateUserAsync() { }
            public async Task GetUserAsync() { }
            public async Task GetUserByIdAsync() { }
            public async Task DeleteUserAsync() { }
        #endregion

    }
}
