using DataAccessLayer.Models.Contents.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Configration_classes
{
    internal class ExamConfigrationClass :BaseOfAllEntityConfigrationClass<Exam>, IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {

            builder.Property(e=>e.Description).HasColumnType("nvarchar(200)").IsRequired(false);
            base.Configure(builder);

        }    }
}
