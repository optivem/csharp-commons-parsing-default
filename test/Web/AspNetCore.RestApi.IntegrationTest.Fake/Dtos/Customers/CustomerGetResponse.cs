﻿using Atomiv.Web.AspNetCore.RestApi.IntegrationTest.Fake.Dtos.Customers.Cards;
using System;
using System.Collections.Generic;

namespace Atomiv.Web.AspNetCore.RestApi.IntegrationTest.Fake.Models
{
    public class CustomerGetResponse
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public List<CustomerCardPutResponse> Cards { get; set; }
    }
}