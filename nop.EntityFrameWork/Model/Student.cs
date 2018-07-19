using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Model
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string CustomProperty { get; set; }
    }
}
