﻿using System;
using System.Collections.Generic;

namespace Atomiv.Template.Core.Application.Queries.Customers
{
    public class BrowseCustomersQueryResponse
    {
        public List<BrowseCustomersRecordResponse> Records { get; set; }

        public long TotalRecords { get; set; }
    }

    public class BrowseCustomersRecordResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}