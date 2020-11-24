using System;
using Alba;
using AutoMapper;
using NorthWind.Api.Repository.MySql;

namespace NorthWind.Api.Integration.Tests
{
    public class WebApiFixture : IDisposable
    {
        public readonly SystemUnderTest systemUnderTest;
        public readonly NorthwindDbContext northWindDbContext;
        public readonly IMapper mapper;
        public WebApiFixture()
        {
            systemUnderTest = SystemUnderTest.ForStartup<Tests.Startup>();
            northWindDbContext = (NorthwindDbContext)systemUnderTest.Services.GetService(typeof(NorthwindDbContext));
            mapper = (IMapper)systemUnderTest.Services.GetService(typeof(IMapper));
        }

        public void Dispose()
        {
            systemUnderTest?.Dispose();
            northWindDbContext?.Dispose();
        }
    }
}
