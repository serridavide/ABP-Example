using stackTest.Entities.Childs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace stackTest.Entities.Fathers
{
    public class CreateUpdateFatherDto
    {
        public string Name { get; set; }
        public Collection<ChildDto> Children { get; set; }
    }
}
