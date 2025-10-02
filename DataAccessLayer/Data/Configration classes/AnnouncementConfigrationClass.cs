﻿using DataAccessLayer.Models.Announcements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Configration_classes
{
    internal class AnnouncementConfigrationClass : BaseOfAllEntityConfigrationClass<Announcement>, IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.Property(a => a.Header).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(a => a.Body).HasColumnType("nvarchar(600)").IsRequired();
            base.Configure(builder);
        }
    }
}
