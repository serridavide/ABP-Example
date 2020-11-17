using stackTest.Entities.Childs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace stackTest.Entities.Fathers
{
    public class FatherDto : AuditedEntityDto<Guid>

    {
        public FatherDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }

        public Collection<ChildDto> Children { get; set; }

    }
}
