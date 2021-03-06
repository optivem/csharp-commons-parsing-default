﻿using AutoMapper;
using Atomiv.Template.Core.Domain.Customers;
using System;

namespace Atomiv.Template.Infrastructure.Commands.Mapping.Common
{
    public class CustomerIdentityProfile : Profile
    {
        public CustomerIdentityProfile()
        {
            CreateMap<CustomerIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}