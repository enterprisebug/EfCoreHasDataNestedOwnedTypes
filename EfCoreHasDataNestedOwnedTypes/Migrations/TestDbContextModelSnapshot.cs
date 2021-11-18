﻿// <auto-generated />
using System;
using EfCoreHasDataNestedOwnedTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreHasDataNestedOwnedTypes.Migrations
{
    [DbContext(typeof(TestDbContext))]
    partial class TestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCoreHasDataNestedOwnedTypes.RootEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RootEntities");
                });

            modelBuilder.Entity("EfCoreHasDataNestedOwnedTypes.RootEntity", b =>
                {
                    b.OwnsOne("EfCoreHasDataNestedOwnedTypes.OwnedEntityLevel1", "OwnedEntityLevel1", b1 =>
                        {
                            b1.Property<Guid>("RootEntityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("RootEntityId");

                            b1.ToTable("RootEntities");

                            b1.WithOwner()
                                .HasForeignKey("RootEntityId");

                            b1.OwnsOne("EfCoreHasDataNestedOwnedTypes.OwnedEntityLevel2", "OwnedEntityLevel2", b2 =>
                                {
                                    b2.Property<Guid>("OwnedEntityLevel1RootEntityId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("Id")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("MyProperty")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("OwnedEntityLevel1RootEntityId");

                                    b2.ToTable("RootEntities");

                                    b2.WithOwner()
                                        .HasForeignKey("OwnedEntityLevel1RootEntityId");
                                });

                            b1.Navigation("OwnedEntityLevel2");
                        });

                    b.Navigation("OwnedEntityLevel1");
                });
#pragma warning restore 612, 618
        }
    }
}
