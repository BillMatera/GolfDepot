﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GolfDeptAppp.Data;

namespace GolfDeptAppp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20171017002714_Category")]
    partial class Category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GolfDeptAppp.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GolfDeptAppp.Data.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPreferredClub");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("ClubId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("GolfDeptAppp.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int?>("ClubId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ClubId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("GolfDeptAppp.Data.Models.Club", b =>
                {
                    b.HasOne("GolfDeptAppp.Data.Models.Category", "Category")
                        .WithMany("Clubs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GolfDeptAppp.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("GolfDeptAppp.Data.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");
                });
        }
    }
}
