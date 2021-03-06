﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Miki.Models;
using System;

namespace Miki.Core.Migrations
{
    [DbContext(typeof(MikiContext))]
    [Migration("20180125225929_fix_key_marriage")]
    partial class fix_key_marriage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Miki.Models.Achievement", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Name");

                    b.Property<short>("Rank");

                    b.Property<DateTime>("UnlockedAt");

                    b.HasKey("Id", "Name");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Miki.Models.ChannelLanguage", b =>
                {
                    b.Property<long>("EntityId")
                        .HasColumnName("EntityId");

                    b.Property<string>("Language")
                        .HasColumnName("Language");

                    b.HasKey("EntityId");

                    b.ToTable("ChannelLanguage");
                });

            modelBuilder.Entity("Miki.Models.CommandUsage", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("Name");

                    b.Property<int>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.HasKey("UserId", "Name");

                    b.ToTable("CommandUsages");
                });

            modelBuilder.Entity("Miki.Models.Connection", b =>
                {
                    b.Property<long>("DiscordUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PatreonUserId");

                    b.HasKey("DiscordUserId");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Miki.Models.EventMessage", b =>
                {
                    b.Property<long>("ChannelId")
                        .HasColumnName("ChannelId");

                    b.Property<short>("EventType")
                        .HasColumnName("EventType");

                    b.Property<string>("Message")
                        .HasColumnName("Message");

                    b.HasKey("ChannelId", "EventType");

                    b.ToTable("EventMessages");
                });

            modelBuilder.Entity("Miki.Models.GlobalPasta", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now()");

                    b.Property<long>("CreatorId");

                    b.Property<int>("Score");

                    b.Property<string>("Text");

                    b.Property<int>("TimesUsed");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Pastas");
                });

            modelBuilder.Entity("Miki.Models.GuildUser", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("EntityId");

                    b.Property<bool>("Banned")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("banned")
                        .HasDefaultValue(false);

                    b.Property<int>("Experience");

                    b.Property<DateTime>("LastRivalRenewed")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now() - INTERVAL '1 day'");

                    b.Property<int>("MinimalExperienceToGetRewards")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(100);

                    b.Property<string>("Name");

                    b.Property<long>("RivalId")
                        .HasDefaultValue(0L);

                    b.Property<int>("UserCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<bool>("VisibleOnLeaderboards")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("GuildUsers");
                });

            modelBuilder.Entity("Miki.Models.LevelRole", b =>
                {
                    b.Property<long>("GuildId");

                    b.Property<long>("RoleId");

                    b.Property<bool>("Automatic")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("Optable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("RequiredLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<long>("RequiredRole")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0L);

                    b.HasKey("GuildId", "RoleId");

                    b.ToTable("LevelRoles");
                });

            modelBuilder.Entity("Miki.Models.LocalExperience", b =>
                {
                    b.Property<long>("ServerId");

                    b.Property<long>("UserId");

                    b.Property<int>("Experience");

                    b.HasKey("ServerId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LocalExperience");
                });

            modelBuilder.Entity("Miki.Models.Marriage", b =>
                {
                    b.Property<long>("MarriageId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsProposing");

                    b.Property<DateTime>("TimeOfMarriage");

                    b.Property<DateTime>("TimeOfProposal")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now()");

                    b.HasKey("MarriageId");

                    b.ToTable("Marriages");
                });

            modelBuilder.Entity("Miki.Models.Objects.Guild.Timer", b =>
                {
                    b.Property<long>("GuildId")
                        .HasColumnName("GuildId");

                    b.Property<long>("UserId")
                        .HasColumnName("UserId");

                    b.Property<DateTime>("Value");

                    b.HasKey("GuildId", "UserId");

                    b.ToTable("Timers");
                });

            modelBuilder.Entity("Miki.Models.PastaVote", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id");

                    b.Property<long>("UserId")
                        .HasColumnName("UserId");

                    b.Property<bool>("PositiveVote")
                        .HasColumnName("PositiveVote");

                    b.HasKey("Id", "UserId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Miki.Models.Setting", b =>
                {
                    b.Property<long>("EntityId")
                        .HasColumnName("EntityId");

                    b.Property<int>("SettingId")
                        .HasColumnName("SettingId");

                    b.Property<bool>("IsEnabled")
                        .HasColumnName("IsEnabled");

                    b.HasKey("EntityId", "SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Miki.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarUrl")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("default");

                    b.Property<bool>("Banned")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<long?>("ConnectionsDiscordUserId");

                    b.Property<int>("Currency")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now()");

                    b.Property<string>("HeaderUrl")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("default");

                    b.Property<DateTime>("LastDailyTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("now() - interval '1 day'");

                    b.Property<int>("MarriageSlots")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Name");

                    b.Property<int>("Reputation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("");

                    b.Property<int>("Total_Commands")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Total_Experience")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("ConnectionsDiscordUserId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Miki.Models.UserMarriedTo", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("MarriageId");

                    b.Property<bool>("Asker");

                    b.HasKey("UserId", "MarriageId");

                    b.HasIndex("MarriageId");

                    b.ToTable("UsersMarriedTo");
                });

            modelBuilder.Entity("Miki.Models.Achievement", b =>
                {
                    b.HasOne("Miki.Models.User", "User")
                        .WithMany("Achievements")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Miki.Models.CommandUsage", b =>
                {
                    b.HasOne("Miki.Models.User", "User")
                        .WithMany("CommandsUsed")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Miki.Models.GlobalPasta", b =>
                {
                    b.HasOne("Miki.Models.User", "User")
                        .WithMany("Pastas")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Miki.Models.LocalExperience", b =>
                {
                    b.HasOne("Miki.Models.User", "User")
                        .WithMany("LocalExperience")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Miki.Models.User", b =>
                {
                    b.HasOne("Miki.Models.Connection", "Connections")
                        .WithOne("User")
                        .HasForeignKey("Miki.Models.User", "ConnectionsDiscordUserId");
                });

            modelBuilder.Entity("Miki.Models.UserMarriedTo", b =>
                {
                    b.HasOne("Miki.Models.Marriage", "Marriage")
                        .WithMany("Participants")
                        .HasForeignKey("MarriageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Miki.Models.User", "User")
                        .WithMany("Marriages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
