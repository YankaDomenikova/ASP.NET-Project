﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210611123230_Add_Romance_Books")]
    partial class Add_Romance_Books
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<int>("BestsellerRank")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("Description")
                        .HasMaxLength(1100)
                        .HasColumnType("nvarchar(1100)");

                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PublicationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = "23c891ac-993d-4d40-9",
                            Author = "Diana Gabaldon",
                            BestsellerRank = 132,
                            Country = "United States",
                            Description = "Claire Beauchamp Randall and Jamie Fraser, in a spellbinding novel of passion and history that combines exhilarating adventure with a love story for the ages. Scottish Highlands, 1945. Claire Randall, a former British combat nurse, is just back from the war and reunited with her husband on a second honeymoon when she walks through a standing stone in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach--an 'outlander'--in a Scotland torn by war and raiding clans in the year of Our Lord . . . 1743. Claire is catapulted into the intrigues of a world that threatens her life, and may shatter her heart. Marooned amid danger, passion, and violence, Claire learns her only chance of safety lies in Jamie Fraser, a gallant young Scots warrior. What begins in compulsion becomes urgent need, and Claire finds herself torn between two very different men, in two irreconcilable lives.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Outlander.jpg",
                            Language = "English",
                            Pages = 896,
                            Price = 16.18,
                            PublicationDate = "01 Aug 1996",
                            Publisher = "Bantam Doubleday Dell Publishing Group Inc",
                            Quantity = 30,
                            Title = "Outlander"
                        },
                        new
                        {
                            Id = "10d27a42-5066-46ca-a",
                            Author = "Lucinda Riley",
                            BestsellerRank = 391,
                            Country = "United Kingdom",
                            Description = "After the death of her father - Pa Salt, an elusive billionaire who adopted his six daughters from around the globe - Tiggy D'Apliese , trusting her instincts, moves to the remote wilds of Scotland. There she takes a job doing what she loves; caring for animals on the vast and isolated Kinnaird estate, employed by the enigmatic and troubled Laird, Charlie Kinnaird.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/TheMoonSister.jpg",
                            Language = "English",
                            Pages = 768,
                            Price = 13.75,
                            PublicationDate = "11 Jul 2019",
                            Publisher = "Pan MacMillan",
                            Quantity = 5,
                            Title = "The Moon Sister"
                        },
                        new
                        {
                            Id = "6c9a8ac2-0cc4-4f64-8",
                            Author = "Casey Mcquiston",
                            BestsellerRank = 11,
                            Country = "United States",
                            Description = "What happens when America's First Son falls in love with the Prince of Wales? When his mother became President, Alex Claremont-Diaz was promptly cast as the American equivalent of a young royal. Handsome, charismatic, genius--his image is pure millennial-marketing gold for the White House.There's only one problem: Alex has a beef with the actual prince, Henry, across the pond. And when the tabloids get hold of a photo involving an Alex-Henry altercation, U.S./British relations take a turn for the worse.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/RedWhiteBlue.jpg",
                            Language = "English",
                            Pages = 432,
                            Price = 31.0,
                            PublicationDate = "14 May 2019",
                            Publisher = "St Martin's Press",
                            Quantity = 3,
                            Title = "Red, White & Royal Blue : A Novel"
                        },
                        new
                        {
                            Id = "ace19c1e-5e5a-4a1b-9",
                            Author = "Colleen Hoover",
                            BestsellerRank = 121,
                            Country = "United Kingdom",
                            Description = "Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily's life suddenly seems almost too good to be true.Ryle is assertive, stubborn, maybe even a little arrogant. He`s also sensitive, brilliant, and has a total soft spot for Lily, but Ryle`s complete aversion to relationships is disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder what made him that way in the first place.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Endswithus.jpg",
                            Language = "English",
                            Pages = 384,
                            Price = 19.949999999999999,
                            PublicationDate = "02 Aug 2016",
                            Publisher = "Simon & Schuster Ltd",
                            Quantity = 4,
                            Title = "It Ends With Us"
                        },
                        new
                        {
                            Id = "bc1848dd-5ba0-4d6b-a",
                            Author = "Lucinda Riley",
                            BestsellerRank = 264,
                            Country = " United Kingdom",
                            Description = "Following on from the bestselling The Seven Sisters and The Storm Sister, The Shadow Sister is the third book in Lucinda Riley's spellbinding series of love and loss, loosely based on the mythology of the Seven Sisters star cluster.Star D`Apliese is at a crossroads in her life after the sudden death of her beloved father - the elusive billionaire, named Pa Salt by his six daughters, all adopted by him from the four corners of the world. He has left each of them a clue to their true heritage, but Star - the most enigmatic of the sisters - is hesitant to step out of the safety of the close relationship she shares with her sister CeCe. In desperation, she decides to follow the first clue she has been left, which leads her to an antiquarian bookshop in London, and the start of a whole new world . . .",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Theshadowsister.jpg",
                            Language = "English",
                            Pages = 720,
                            Price = 21.82,
                            PublicationDate = "11 Jul 2019",
                            Publisher = "Pan MacMillan",
                            Quantity = 6,
                            Title = "The Shadow Sister"
                        },
                        new
                        {
                            Id = "e0423cb7-9d7e-427f-a",
                            Author = "Casey Mcquiston",
                            BestsellerRank = 168,
                            Country = "United States",
                            Description = "For cynical twenty-three-year-old August, moving to New York City is supposed to prove her right: that things like magic and cinematic love stories don't exist, and the only smart way to go through life is alone. She can't imagine how waiting tables at a 24-hour pancake diner and moving in with too many weird roommates could possibly change that. And there's certainly no chance of her subway commute being anything more than a daily trudge through boredom and electrical failures.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Onelaststop.jpg",
                            Language = "English",
                            Pages = 432,
                            Price = 24.030000000000001,
                            PublicationDate = "01 Jun 2021",
                            Publisher = "St Martin's Press",
                            Quantity = 0,
                            Title = "One Last Stop"
                        },
                        new
                        {
                            Id = "bfa7fb8c-2994-408f-b",
                            Author = "Morgan Rogers",
                            BestsellerRank = 280,
                            Country = "United States",
                            Description = "With her newly completed PhD in astronomy in hand, twenty-eight-year-old Grace Porter goes on a girls' trip to Vegas to celebrate. She's a straight A, work-through-the-summer certified high achiever. She is not the kind of person who goes to Vegas and gets drunkenly married to a woman whose name she doesn't know...until she does exactly that. This one moment of departure from her stern ex-military father's plans for her life has Grace wondering why she doesn`t feel more fulfilled from completing her degree. Staggering under the weight of her parent's expectations, a struggling job market and feelings of burnout, Grace flees her home in Portland for a summer in New York with the wife she barely knows.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Honeygirl.jpg",
                            Language = "English",
                            Pages = 304,
                            Price = 17.84,
                            PublicationDate = "23 Feb 2021",
                            Publisher = "Park Row",
                            Quantity = 0,
                            Title = "Honey Girl"
                        },
                        new
                        {
                            Id = "747ce5ca-01ec-4cf2-8",
                            Author = "Sally Rooney",
                            BestsellerRank = 141,
                            Country = "United Kingdom",
                            Description = "Connell and Marianne grow up in the same small town in the west of Ireland, but the similarities end there. In school, Connell is popular and well-liked, while Marianne is a loner. But when the two strike up a conversation - awkward but electrifying - something life-changing begins. Normal People is a story of mutual fascination, friendship and love. It takes us from that first conversation to the years beyond, in the company of two people who try to stay apart but find they can't.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Normalpoeple.jpg",
                            Language = "English",
                            Pages = 288,
                            Price = 19.57,
                            PublicationDate = "23 Jul 2019",
                            Publisher = "FABER & FABER",
                            Quantity = 2,
                            Title = "Normal People"
                        },
                        new
                        {
                            Id = "21eee644-7554-44d0-b",
                            Author = " Rainbow Rowell",
                            BestsellerRank = 149,
                            Country = "United Kingdom",
                            Description = "Cath and Wren are identical twins, and until recently they did absolutely everything together. Now they're off to university and Wren's decided she doesn't want to be one half of a pair any more - she wants to dance, meet boys, go to parties and let loose. It's not so easy for Cath. She's horribly shy and has always buried herself in the fan fiction she writes, where she always knows exactly what to say and can write a romance far more intense than anything she's experienced in real life.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Fangirl.jpg",
                            Language = "English",
                            Pages = 480,
                            Price = 19.57,
                            PublicationDate = "30 Jan 2014",
                            Publisher = "Pan MacMillan",
                            Quantity = 20,
                            Title = "Fangirl"
                        },
                        new
                        {
                            Id = "3fbc718d-06c9-4aa4-b",
                            Author = " Rainbow Rowell",
                            BestsellerRank = 264,
                            Country = "United Kingdom",
                            Description = "Eleanor is the new girl in town, and she's never felt more alone. All mismatched clothes, mad red hair and chaotic home life, she couldn't stick out more if she tried. Then she takes the seat on the bus next to Park. Quiet, careful and - in Eleanor's eyes - impossibly cool, Park's worked out that flying under the radar is the best way to get by. Slowly, steadily, through late-night conversations and an ever-growing stack of mix tapes, Eleanor and Park fall in love. They fall in love the way you do the first time, when you're 16, and you have nothing and everything to lose.",
                            GenreTitle = "Romance",
                            ImageUrl = "https://localhost:5001/images/romance/Eleanorpark.jpg",
                            Language = "English",
                            Pages = 336,
                            Price = 17.050000000000001,
                            PublicationDate = "07 Jul 2014",
                            Publisher = "Orion Publishing Co",
                            Quantity = 12,
                            Title = "Eleanor & Park"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Genre", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasMaxLength(1100)
                        .HasColumnType("nvarchar(1100)");

                    b.Property<string>("Title")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.HasOne("BookStore.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}