﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

// <auto-generated />
using System;
using MSDF.DataChecker.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSDF.DataChecker.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200609174215_EdFiRuleExecutionLogDetails")]
    partial class EdFiRuleExecutionLogDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Catalogs.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Collections.Container", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContainerTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnvironmentType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentContainerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContainerTypeId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("ParentContainerId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Collections.ContainerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Collection"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Folder"
                        });
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.DatabaseEnvironments.DatabaseEnvironment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Database")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapTables")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SecurityIntegrated")
                        .HasColumnType("bit");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DatabaseEnvironments");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.EdFiRuleExecutionLogDetails.EdFiRuleExecutionLogDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EducationOrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("OtherDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RuleExecutionLogId")
                        .HasColumnType("int");

                    b.Property<string>("StaffUniqueId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUniqueId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RuleExecutionLogId");

                    b.ToTable("EdFiRuleExecutionLogDetails");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Logs.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.RuleExecutionLogs.RuleExecutionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("DatabaseEnvironmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiagnosticSql")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Evaluation")
                        .HasColumnType("bit");

                    b.Property<string>("ExecutedSql")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExecutionDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ExecutionTimeMs")
                        .HasColumnType("bigint");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<Guid>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RuleId");

                    b.ToTable("RuleExecutionLogs");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Rules.Rule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnosticSql")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ErrorSeverityLevel")
                        .HasColumnType("int");

                    b.Property<string>("EvaluationOperand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpectedResult")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RuleIdentification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sql")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Tags.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Tags.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("ContainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.HasIndex("RuleId");

                    b.HasIndex("TagId");

                    b.ToTable("TagEntities");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.UserParams.UserParam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DatabaseEnvironmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DatabaseEnvironmentId");

                    b.ToTable("UserParams");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Collections.Container", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.Collections.ContainerType", "ContainerType")
                        .WithMany()
                        .HasForeignKey("ContainerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSDF.DataChecker.Persistence.Collections.Container", "ParentContainer")
                        .WithMany("ChildContainers")
                        .HasForeignKey("ParentContainerId");
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.EdFiRuleExecutionLogDetails.EdFiRuleExecutionLogDetail", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.RuleExecutionLogs.RuleExecutionLog", "RuleExecutionLog")
                        .WithMany()
                        .HasForeignKey("RuleExecutionLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.RuleExecutionLogs.RuleExecutionLog", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.Rules.Rule", null)
                        .WithMany("RuleExecutionLogs")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Rules.Rule", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.Collections.Container", null)
                        .WithMany("Rules")
                        .HasForeignKey("ContainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.Tags.TagEntity", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.Collections.Container", "Container")
                        .WithMany()
                        .HasForeignKey("ContainerId");

                    b.HasOne("MSDF.DataChecker.Persistence.Rules.Rule", "Rule")
                        .WithMany()
                        .HasForeignKey("RuleId");

                    b.HasOne("MSDF.DataChecker.Persistence.Tags.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MSDF.DataChecker.Persistence.UserParams.UserParam", b =>
                {
                    b.HasOne("MSDF.DataChecker.Persistence.DatabaseEnvironments.DatabaseEnvironment", null)
                        .WithMany("UserParams")
                        .HasForeignKey("DatabaseEnvironmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
