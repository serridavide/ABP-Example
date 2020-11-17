using stackTest.Entities.Fathers;
using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Entities.Childs
{
    public class CreateUpdateChildDto
    {
        public string Name { get; set; }
        public FatherDto Father { get; set; }
    }
}
