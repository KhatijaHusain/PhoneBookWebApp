using CibDigiTechWebApp.Dto;
using CibDigiTechWebApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.DbContexts
{
    public class PhoneBookConfiguration : IEntityTypeConfiguration<PhoneBookDto>
    {
        public void Configure(EntityTypeBuilder<PhoneBookDto> builder)
        {
            builder.ToTable("PhoneBook");

            builder.HasKey(x => x.PhoneBookId);

            builder.Property(e => e.PhoneBookId)
                .HasColumnName("phone_book_id")
                .HasColumnType("integer");

            builder.Property(e => e.PhoneBookName)
                .HasColumnName("phone_book_name")
                .HasColumnType("character varying")
                .IsRequired();
        }
    }
}
