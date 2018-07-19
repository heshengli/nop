using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Model
{
    /// <summary>
    /// 实体映射表
    /// </summary>
    public partial class StudentMap : NopEntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.ToTable("Student");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();
        }
    }
}
