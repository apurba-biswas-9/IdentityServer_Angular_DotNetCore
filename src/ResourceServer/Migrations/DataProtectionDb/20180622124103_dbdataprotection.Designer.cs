﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResourceServer.DataProtection;

namespace ResourceServer.Migrations.DataProtectionDb
{
    [DbContext(typeof(DataProtectionDbContext))]
    [Migration("20180622124103_dbdataprotection")]
    partial class dbdataprotection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResourceServer.DataProtection.DataProtectionElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Xml");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionXMLElements");
                });
#pragma warning restore 612, 618
        }
    }
}
