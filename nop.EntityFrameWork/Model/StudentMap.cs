using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Model
{
    /// <summary>
    /// 实体映射表nop拓展
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

    /// <summary>
    /// 原生ef
    /// </summary>
    //public partial class StudentMap2 : EntityTypeConfiguration<Student>
    //{
    //    public StudentMap2()
    //    {
    //        this.ToTable("Student");
    //        this.HasKey(pa => pa.Id);
    //        this.Property(pa => pa.Name).IsRequired();
    //    }
    //}
}
