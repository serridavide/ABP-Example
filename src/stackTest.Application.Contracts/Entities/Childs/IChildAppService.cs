using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace stackTest.Entities.Childs
{
    public interface IChildAppService : ICrudAppService<
            ChildDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateChildDto>
    {

    }
}
