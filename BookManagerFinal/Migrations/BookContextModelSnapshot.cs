﻿// <auto-generated />
using BookManagerFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagerFinal.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookManagerFinal.Models.BookModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(999)
                        .HasColumnType("nvarchar(999)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(999)
                        .HasColumnType("nvarchar(999)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Genre = "The Song of Achilles by Madeline Miller retells the Trojan War through the eyes of Patroclus focusing on his deep, passionate love for the legendary Greek warrior Achilles",
                            Name = "Song of Achilles",
                            Rating = 5,
                            Status = "read",
                            Summary = "young adult"
                        },
                        new
                        {
                            BookId = 2,
                            Genre = "fantasy",
                            Name = "Harry Potter and the Prisoner of Azkaban",
                            Rating = 5,
                            Status = "read",
                            Summary = "Harry Potter enters his third year at HOgwarts only to be greeted by a tense atmosphere caused by a prisson at Azkaban escaping. Harry along with his friends learn of a connection between the prisoner and his parents. Learning of his innocence Harry travels back in time to set things right."
                        },
                        new
                        {
                            BookId = 3,
                            Genre = "young adult",
                            Name = "I'll Give You the Sun",
                            Rating = 4,
                            Status = "will read",
                            Summary = "A brother and sister, who once were inseparable but have driven each other away. As the twins get older, and figure out what kind of people they want to be, they start to see each other and their parents not just as extensions of themselves, but as individuals."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
