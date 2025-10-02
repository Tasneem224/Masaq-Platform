﻿using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Configration_classes
{
    internal class BaseOfAllEntityConfigrationClass<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseOfAllContentEntities
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {

            builder.Property(b => b.Id).UseIdentityColumn(1, 1);
            builder.Property(d => d.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(d => d.LastModifiedOn).HasComputedColumnSql("GETDATE()");

        }
    }
}
