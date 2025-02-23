﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanistaAPI.DataLayer;

#nullable disable

namespace PlanistaAPI.Migrations
{
    [DbContext(typeof(PlanistaDbContext))]
    [Migration("20220517123904_ErrandCategory")]
    partial class ErrandCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("longtext")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)")
                        .HasColumnName("role_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("RoleId", "UserId")
                        .HasName("pk_iu_roles");

                    b.ToTable("iu_roles", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("int")
                        .HasColumnName("building_number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("city");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("int")
                        .HasColumnName("flat_number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("zip_code");

                    b.HasKey("Id")
                        .HasName("pk_addresses");

                    b.ToTable("addresses", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("nip");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.HasIndex("AddressId")
                        .HasDatabaseName("ix_companies_address_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_companies_user_id");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Errand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("event_id");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_errands");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_errands_category_id");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_errands_company_id");

                    b.HasIndex("EventId")
                        .HasDatabaseName("ix_errands_event_id");

                    b.ToTable("errands", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_events");

                    b.HasIndex("AddressId")
                        .HasDatabaseName("ix_events_address_id");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_events_category_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_events_user_id");

                    b.ToTable("events", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("contents");

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("event_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_notes");

                    b.HasIndex("EventId")
                        .HasDatabaseName("ix_notes_event_id");

                    b.ToTable("notes", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Opinion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("add_date");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("contents");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_opinions");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_opinions_company_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_opinions_user_id");

                    b.ToTable("opinions", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.ToDoListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("event_id");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_to_do_list_items");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_to_do_list_items_category_id");

                    b.HasIndex("EventId")
                        .HasDatabaseName("ix_to_do_list_items_event_id");

                    b.ToTable("to_do_list_items", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_joined");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("lockout_enabled");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext")
                        .HasColumnName("password_hash");

                    b.Property<string>("Role")
                        .HasColumnType("longtext")
                        .HasColumnName("role");

                    b.Property<bool>("UserActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("user_active");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Company", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_companies_addresses_address_id");

                    b.HasOne("PlanistaAPI.DataLayer.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_companies_users_user_id");

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Errand", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Category", "Category")
                        .WithMany("Errands")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_errands_categories_category_id");

                    b.HasOne("PlanistaAPI.DataLayer.Company", "Company")
                        .WithMany("Errands")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_errands_companies_company_id");

                    b.HasOne("PlanistaAPI.DataLayer.Event", "Event")
                        .WithMany("Errands")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_errands_events_event_id");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Event", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Address", "Address")
                        .WithMany("Events")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("fk_events_addresses_address_id");

                    b.HasOne("PlanistaAPI.DataLayer.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_events_categories_category_id");

                    b.HasOne("PlanistaAPI.DataLayer.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_events_users_user_id");

                    b.Navigation("Address");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Note", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Event", "Event")
                        .WithMany("Notes")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_notes_events_event_id");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Opinion", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Company", "Company")
                        .WithMany("Opinions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_opinions_companies_company_id");

                    b.HasOne("PlanistaAPI.DataLayer.User", "User")
                        .WithMany("Opinions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_opinions_users_user_id");

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.ToDoListItem", b =>
                {
                    b.HasOne("PlanistaAPI.DataLayer.Category", "Category")
                        .WithMany("ToDoListItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_to_do_list_items_categories_category_id");

                    b.HasOne("PlanistaAPI.DataLayer.Event", "Event")
                        .WithMany("ToDoListItems")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_to_do_list_items_events_event_id");

                    b.Navigation("Category");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Address", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Category", b =>
                {
                    b.Navigation("Errands");

                    b.Navigation("Events");

                    b.Navigation("ToDoListItems");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Company", b =>
                {
                    b.Navigation("Errands");

                    b.Navigation("Opinions");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.Event", b =>
                {
                    b.Navigation("Errands");

                    b.Navigation("Notes");

                    b.Navigation("ToDoListItems");
                });

            modelBuilder.Entity("PlanistaAPI.DataLayer.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Events");

                    b.Navigation("Opinions");
                });
#pragma warning restore 612, 618
        }
    }
}
