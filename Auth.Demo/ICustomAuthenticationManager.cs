﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Demo
{
    public interface ICustomAuthenticationManager
    {
        string Authenticate(string username, string password);
        IDictionary<string, Tuple<string, string>> Tokens { get; }
    }
}
