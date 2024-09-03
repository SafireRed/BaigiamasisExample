﻿using Microsoft.AspNetCore.Mvc;

namespace BaigiamasisExample.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(string username, string role);
    }
}
