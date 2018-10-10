using AutoMapper;
using MvcTests.Models;
using MvcTestsDomainModel;

namespace MVCTests.Configs
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<TestDomainModel, TestViewModel>().ReverseMap();
            });
        }
    }
}