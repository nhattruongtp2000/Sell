using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sell.Data.EF.Extensions;
using Sell.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Data.EF.Configurations
{
    public class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128);
        }
    }
}
