﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Code
{
    public interface IAppUser
    {
        bool Login(string UserName, string Password);

        List<AppUser> GetAll();

        void SetAuthentication(string UserName, bool IsAuthenticated);

        AppUser GetByUserName(string UserName);
    }
}
