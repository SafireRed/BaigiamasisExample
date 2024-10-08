﻿using BaigiamasisExample.Models;
using System.Security.Cryptography;
using System.Text;

namespace BaigiamasisExample.Services.Interfaces
{
    public interface IUserService
    {
        void Register(string username, string password, string role);
        bool Login(string username, string password, out string role);
    }
}
