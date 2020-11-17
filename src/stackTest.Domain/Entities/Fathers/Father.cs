using stackTest.Entities.Childs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace stackTest.Entities.Fathers
{
    public class Father : AuditedAggregateRoot<Guid>
    {
        public Father(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public  string Name { get; set; }

        public  Collection<Child> Children { get; set; }

    }
}
