﻿using System;

namespace Atomiv.Template.Core.Application.Commands.Customers
{
    public class CreateCustomerCommandResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
