﻿// <auto-generated />
using System;
using GuessingGame.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuessingGame.Migrations
{
    [DbContext(typeof(GuessingGameContext))]
    [Migration("20190415053410_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("GuessingGame.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerScore");

                    b.Property<DateTime>("ScoreLog");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("Score");
                });
#pragma warning restore 612, 618
        }
    }
}
