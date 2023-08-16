﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockAPI.Data;

#nullable disable

namespace StockAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("StockAPI.Models.Activity", b =>
                {
                    b.Property<DateTime>("DateActivite")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomClientFournisseur")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumBon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeActivite")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("StockAPI.Models.CurrentMonthMostCommandedTopThree", b =>
                {
                    b.Property<int>("command_number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("commanded_quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("product_description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("product_image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("TopThreeCommands");
                });

            modelBuilder.Entity("StockAPI.Models.CurrentMonthMostOrderedTopThree", b =>
                {
                    b.Property<int>("order_number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ordered_quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("product_description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("product_image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("TopThreeOrders");
                });

            modelBuilder.Entity("StockAPI.Models.Destockage", b =>
                {
                    b.Property<string>("num_facture")
                        .HasColumnType("TEXT");

                    b.Property<string>("num_produit")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sortienum_facture")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite_sortie")
                        .HasColumnType("INTEGER");

                    b.HasKey("num_facture", "num_produit");

                    b.HasIndex("Sortienum_facture");

                    b.HasIndex("num_produit");

                    b.ToTable("Destockages");
                });

            modelBuilder.Entity("StockAPI.Models.Entree", b =>
                {
                    b.Property<string>("num_bon_liv")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateEntree")
                        .HasColumnType("TEXT");

                    b.Property<string>("Productnum_produit")
                        .HasColumnType("TEXT");

                    b.Property<string>("nom_fournisseur")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("num_bon_liv");

                    b.HasIndex("Productnum_produit");

                    b.ToTable("Entrees");
                });

            modelBuilder.Entity("StockAPI.Models.MostOrdered", b =>
                {
                    b.Property<int>("ordered_quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("MostsOrdered");
                });

            modelBuilder.Entity("StockAPI.Models.Order", b =>
                {
                    b.Property<DateTime>("dateSortie")
                        .HasColumnType("TEXT");

                    b.Property<string>("design")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nom_client")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_facture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_produit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite_sortie")
                        .HasColumnType("INTEGER");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StockAPI.Models.Product", b =>
                {
                    b.Property<string>("num_produit")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("design")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite")
                        .HasColumnType("INTEGER");

                    b.HasKey("num_produit");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StockAPI.Models.Record", b =>
                {
                    b.Property<DateTime>("dateEntree")
                        .HasColumnType("TEXT");

                    b.Property<string>("design")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nom_fournisseur")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_bon_liv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_produit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite_entree")
                        .HasColumnType("INTEGER");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("StockAPI.Models.Sortie", b =>
                {
                    b.Property<string>("num_facture")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Productnum_produit")
                        .HasColumnType("TEXT");

                    b.Property<string>("nom_cli")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("num_facture");

                    b.HasIndex("Productnum_produit");

                    b.ToTable("Sorties");
                });

            modelBuilder.Entity("StockAPI.Models.StatisticsResult", b =>
                {
                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NbrEntree")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NbrSortie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.ToTable("StatisticsResults");
                });

            modelBuilder.Entity("StockAPI.Models.Stockage", b =>
                {
                    b.Property<string>("num_bon_liv")
                        .HasColumnType("TEXT");

                    b.Property<string>("num_produit")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Entreenum_bon_liv")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite_entree")
                        .HasColumnType("INTEGER");

                    b.HasKey("num_bon_liv", "num_produit");

                    b.HasIndex("Entreenum_bon_liv");

                    b.HasIndex("num_produit");

                    b.ToTable("Stockages");
                });

            modelBuilder.Entity("StockAPI.Models.StockageWithDesignation", b =>
                {
                    b.Property<string>("design")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_bon_liv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("num_produit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantite_entree")
                        .HasColumnType("INTEGER");

                    b.ToTable("StockagesWithDesignation");
                });

            modelBuilder.Entity("StockAPI.Models.Destockage", b =>
                {
                    b.HasOne("StockAPI.Models.Sortie", null)
                        .WithMany("Destockages")
                        .HasForeignKey("Sortienum_facture");

                    b.HasOne("StockAPI.Models.Sortie", "Sorties")
                        .WithMany("Products")
                        .HasForeignKey("num_facture")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockAPI.Models.Product", "Products")
                        .WithMany("Sorties")
                        .HasForeignKey("num_produit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("Sorties");
                });

            modelBuilder.Entity("StockAPI.Models.Entree", b =>
                {
                    b.HasOne("StockAPI.Models.Product", null)
                        .WithMany("Entry")
                        .HasForeignKey("Productnum_produit");
                });

            modelBuilder.Entity("StockAPI.Models.Sortie", b =>
                {
                    b.HasOne("StockAPI.Models.Product", null)
                        .WithMany("Exit")
                        .HasForeignKey("Productnum_produit");
                });

            modelBuilder.Entity("StockAPI.Models.Stockage", b =>
                {
                    b.HasOne("StockAPI.Models.Entree", null)
                        .WithMany("Stockages")
                        .HasForeignKey("Entreenum_bon_liv");

                    b.HasOne("StockAPI.Models.Entree", "Entrees")
                        .WithMany("Products")
                        .HasForeignKey("num_bon_liv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockAPI.Models.Product", "Products")
                        .WithMany("Entrees")
                        .HasForeignKey("num_produit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrees");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("StockAPI.Models.Entree", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Stockages");
                });

            modelBuilder.Entity("StockAPI.Models.Product", b =>
                {
                    b.Navigation("Entrees");

                    b.Navigation("Entry");

                    b.Navigation("Exit");

                    b.Navigation("Sorties");
                });

            modelBuilder.Entity("StockAPI.Models.Sortie", b =>
                {
                    b.Navigation("Destockages");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
