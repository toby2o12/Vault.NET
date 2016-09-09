﻿using System;
using Vault.Endpoints;
using Vault.Endpoints.Sys;

namespace Vault
{
    public interface IVaultClient : IDisposable
    {
        ISysEndpoint Sys { get; }
        ILogical Logical { get; }
    }
}
