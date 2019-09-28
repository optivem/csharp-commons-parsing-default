﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Framework.Core.Domain
{
    public interface IFindAggregatesRepository<TAggregateRoot, TIdentity> 
        : IRepository<TAggregateRoot, TIdentity>
        where TAggregateRoot : IAggregateRoot<TIdentity>
        where TIdentity : IIdentity
    {
        Task<IEnumerable<TAggregateRoot>> GetAsync();
    }
}