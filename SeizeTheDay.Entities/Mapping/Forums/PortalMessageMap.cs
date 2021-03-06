﻿using SeizeTheDay.Core.Domain.Forums;

namespace SeizeTheDay.Entities.Mapping.Forums
{
    public partial class PortalMessageMap : SystemEntityTypeConfiguration<PortalMessage>
    {
        public PortalMessageMap()
        {
            this.ToTable("PortalMessage");
            this.HasKey(pm => pm.Id);
            this.Property(pm => pm.Text).IsRequired().HasMaxLength(256);

            this.HasRequired(fp => fp.User)
              .WithMany()
              .HasForeignKey(fp => fp.CreatedBy)
              .WillCascadeOnDelete(false);
        }
    }
}
