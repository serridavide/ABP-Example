using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace stackTest.Entities.Childs
{
    public class ChildAppService :
        CrudAppService<
            Child, //The Book entity
            ChildDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateChildDto>, //Used to create/update a book
            IChildAppService //implement the IBookAppService
    {
        public ChildAppService(IRepository<Child, Guid> repository)
            : base(repository)
        {

        }

    }
}
