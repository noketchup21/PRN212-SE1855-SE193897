﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_EF;
using DataAccessLayer_EF;

namespace Repositories_EF
{
    public class AccountMemberRepository : IAccountMemberRepository
    {
        AccountMemberDAO accountMemberDAO = new AccountMemberDAO();
        public AccountMember Login(string email, string pwd)
        {
            return accountMemberDAO.Login(email, pwd);
        }
    }
}
