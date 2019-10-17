using CibDigiTechWebApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.DbContexts
{
    public class EntryBookConfiguration : IEntityTypeConfiguration<EntryBookDto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EntryBookDto> builder)
        {
            builder.ToTable("entrybook");

            builder.HasKey(x => x.PersonId);

            builder.Property(e => e.PersonId)
                .HasColumnName("person_id")
                .HasColumnType("integer");

            builder.Property(e => e.PersonName)
                .HasColumnName("person_name")
                .HasColumnType("character varying")
                .IsRequired();

            builder.Property(e => e.PhoneNo)
               .HasColumnName("phone_no")
               .HasColumnType("integer")
               .IsRequired();

            builder.Property(e => e.PhoneBookId)
              .HasColumnName("phone_book_id")
              .HasColumnType("integer")
              .IsRequired();

        }
    }
}
