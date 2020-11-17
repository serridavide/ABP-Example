using AutoMapper;
using stackTest.Entities.Childs;
using stackTest.Entities.Fathers;
using static stackTest.StackTestAppService;

namespace stackTest
{
    public class stackTestApplicationAutoMapperProfile : Profile
    {
        public stackTestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Child, ChildDto>();
            CreateMap<CreateUpdateChildDto, Child>();
            CreateMap<Father, FatherDto>();
            CreateMap<CreateUpdateFatherDto, Father>();
        }
    }
}
