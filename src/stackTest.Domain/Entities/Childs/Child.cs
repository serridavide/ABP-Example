using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using stackTest.Entities.Fathers;

namespace stackTest.Entities.Childs
{
    public class Child : AuditedAggregateRoot<Guid>
    {

        public Child(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public  string Name { get; set; }

        public  Father Father { get; set; }
    }
}
