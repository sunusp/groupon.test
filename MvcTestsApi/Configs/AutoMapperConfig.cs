using AutoMapper;
using MvcTestsApi.Models;
using MvcTestsDomainModel;

namespace MvcTestsApi.Configs
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<TestDto, TestDomainModel>().ReverseMap();
            });
        }
    }
}