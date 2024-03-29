﻿// <auto-generated />
using System;
using GerenciamentoDeCampeonato.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoDeCampeonato.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221115121034_SeventhMigration")]
    partial class SeventhMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EventType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EVENTO");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal?>("MarketValue")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("PLAYERS");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerTeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("TournamentId");

                    b.HasIndex("WinnerTeamId");

                    b.ToTable("MATCH");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("Emblem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("StadiumName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TEAM");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.TimeTorneio", b =>
                {
                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("TournamentId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("TEAMTOURNAMENT");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Torneio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BestPlayerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ChampionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal>("ChampionReward")
                        .HasColumnType("decimal(12,5)");

                    b.Property<int?>("GolderBootId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NumberOfTeams")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BestPlayerId");

                    b.HasIndex("ChampionId");

                    b.HasIndex("GolderBootId");

                    b.ToTable("TOURNAMENT");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Transferencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NewTeamId")
                        .HasColumnType("int");

                    b.Property<int>("OldTeamId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TransferFee")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("NewTeamId");

                    b.HasIndex("OldTeamId");

                    b.HasIndex("PlayerId");

                    b.ToTable("TRANSFER");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Jogador", b =>
                {
                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Partida", b =>
                {
                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Torneio", "Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "WinnerTeam")
                        .WithMany()
                        .HasForeignKey("WinnerTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("Tournament");

                    b.Navigation("WinnerTeam");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.TimeTorneio", b =>
                {
                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "Team")
                        .WithMany("TeamTournament")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Torneio", "Tournament")
                        .WithMany("TeamTournament")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Torneio", b =>
                {
                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Jogador", "BestPlayer")
                        .WithMany()
                        .HasForeignKey("BestPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "Champion")
                        .WithMany()
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Jogador", "GolderBoot")
                        .WithMany()
                        .HasForeignKey("GolderBootId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BestPlayer");

                    b.Navigation("Champion");

                    b.Navigation("GolderBoot");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Transferencia", b =>
                {
                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "NewTeam")
                        .WithMany()
                        .HasForeignKey("NewTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Time", "OldTeam")
                        .WithMany()
                        .HasForeignKey("OldTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoDeCampeonato.Models.Entities.Jogador", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewTeam");

                    b.Navigation("OldTeam");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Time", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("TeamTournament");
                });

            modelBuilder.Entity("GerenciamentoDeCampeonato.Models.Entities.Torneio", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("TeamTournament");
                });
#pragma warning restore 612, 618
        }
    }
}
