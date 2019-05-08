﻿using System;

namespace Optivem.Web.AspNetCore.Fake.Dtos.Customers
{
    public class CustomerGetCollectionResponse
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public int CardCount { get; set; }
    }
}