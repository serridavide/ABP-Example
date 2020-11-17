using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace stackTest.Entities.Fathers
{
    public class FatherAppService :
        CrudAppService<
            Father, //The Book entity
            FatherDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateFatherDto>, //Used to create/update a book
            IFatherAppService //implement the IBookAppService
    {
        public FatherAppService(IRepository<Father, Guid> repository)
            : base(repository)
        {

        }

    }
}
