﻿using DataAccessLayer.Models.Contents.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Configration_classes
{
    internal class QuestionConfigrationClasses :BaseOfAllEntityConfigrationClass<Question> ,IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            builder.Property(q => q.Header).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(q => q.Body).HasColumnType("nvarchar(600)").IsRequired();
            builder.Property(t => t.Type)
                .HasConversion((question) => question.ToString(),
                (toquestion) => (QuestionType)Enum.Parse(typeof(QuestionType), toquestion))
                .HasMaxLength(10).IsRequired();
            base.Configure(builder);
        }
    }
}
