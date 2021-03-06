﻿using Atomiv.Test.Xunit;
using Atomiv.Web.AspNetCore.RestApi.IntegrationTest.Fixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Atomiv.Web.AspNetCore.RestApi.IntegrationTest
{
    public class ExceptionsControllerTest : FixtureTest<TestClient>
    {
        public ExceptionsControllerTest(TestClient client)
            : base(client)
        {
        }

        [Fact(Skip = "Check if method needed")]
        public async Task TestGetAsyncReturnsInternalServerError()
        {
            var response = await Fixture.Exceptions.GetAsync(500);
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Fact(Skip = "Check if method needed")]
        public async Task TestGetAsyncReturnsBadRequestError()
        {
            var response = await Fixture.Exceptions.GetAsync(400);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}