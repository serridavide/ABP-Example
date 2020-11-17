using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace stackTest.Entities.Fathers
{
    public interface IFatherAppService : ICrudAppService<
            FatherDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateFatherDto>
    {

    }
}
