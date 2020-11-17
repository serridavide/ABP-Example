using stackTest.Entities.Fathers;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace stackTest.Entities.Childs
{
    public class ChildDto : AuditedEntityDto<Guid>
    {
        public ChildDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }

        public FatherDto Father { get; set; }
    }
}
