using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class Add_Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1100)", maxLength: 1100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1750)", maxLength: 1750, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
                    BestsellerRank = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GenreTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BestsellerRank", "Country", "Description", "GenreId", "GenreTitle", "ImageUrl", "Language", "Pages", "Price", "PublicationDate", "Publisher", "Quantity", "Title" },
                values: new object[,]
                {
                    { "d3bcf259-1578-4f49-b", "Diana Gabaldon", 132, "United States", "Claire Beauchamp Randall and Jamie Fraser, in a spellbinding novel of passion and history that combines exhilarating adventure with a love story for the ages. Scottish Highlands, 1945. Claire Randall, a former British combat nurse, is just back from the war and reunited with her husband on a second honeymoon when she walks through a standing stone in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach--an 'outlander'--in a Scotland torn by war and raiding clans in the year of Our Lord . . . 1743. Claire is catapulted into the intrigues of a world that threatens her life, and may shatter her heart. Marooned amid danger, passion, and violence, Claire learns her only chance of safety lies in Jamie Fraser, a gallant young Scots warrior. What begins in compulsion becomes urgent need, and Claire finds herself torn between two very different men, in two irreconcilable lives.", null, "Romance", "https://localhost:5001/images/romance/Outlander.jpg", "English", 896, 16.18, "01 Aug 1996", "Bantam Doubleday Dell Publishing Group Inc", 30, "Outlander" },
                    { "9a8122c3-2fe3-4305-a", "Cixin Liu ", 166, " United Kingdom", "Earth enjoys unprecedented prosperity due to the infusion of Trisolaran knowledge and, with human science advancing and the Trisolarans adopting Earth culture, it seems that the two civilizations can co-exist peacefully as equals without the terrible threat of mutually assured annihilation. But peace has made humanity complacent.", null, "Science Fiction", "https://localhost:5001/images/fiction/DeathsEnd.jpg", "English", 608, 27.5, "04 May 2017", "Head of Zeus", 20, "Death's End" },
                    { "73a67b77-d802-4538-a", "Orson Scott Card", 461, "United States", "Ender's Game is the classic Hugo and Nebula award-winning science fiction novel of a young boy's recruitment into the midst of an interstellar war. In order to develop a secure defense against a hostile alien race's next attack, government agencies breed child geniuses and train them as soldiers. A brilliant young boy, Andrew Ender Wiggin lives with his kind but distant parents, his sadistic brother Peter, and the person he loves more than anyone else, his sister Valentine. Peter and Valentine were candidates for the soldier-training program but didn't make the cut--young Ender is the Wiggin drafted to the orbiting Battle School for rigorous military training. Ender's skills make him a leader in school and respected in the Battle Room, where children play at mock battles in zero gravity. Yet growing up in an artificial community of young soldiers Ender suffers greatly from isolation, rivalry from his peers, pressure from the adult teachers, and an unsettling fear of the alien invaders. His psychological battles include loneliness, fear that he is becoming like the cruel brother he remembers, and fanning the flames of devotion to his beloved sister. ", null, "Science Fiction", "https://localhost:5001/images/fiction/EndersGame.jpg", "English", 375, 18.850000000000001, "30 Nov 1998", "Tor Books", 3, "Ender's Game" },
                    { "41c1ee21-6481-47f4-8", "Andy Weir", 980, "United Kingdom", "Jazz Bashara is one of the criminals. She lives in a poor area of Artemis and subsidises her work as a porter with smuggling contraband onto the moon. But it's not enough.So when she's offered the chance to make a lot of money she jumps at it. But though planning a crime in 1/6th gravity may be more fun, it's also a lot more dangerous.When you live on the moon, of course you have a dark side...", null, "Science Fiction", "https://localhost:5001/images/fiction/Artemis.jpg", "English", 320, 21.66, "12 Jul 2018", "Cornerstone", 2, "Artemis" },
                    { "968793e7-7542-4c76-8", "George Orwell", 77, "United Kingdom", "Mr Jones of Manor Farm is so lazy and drunken that one day he forgets to feed his livestock. The ensuing rebellion under the leadership of the pigs Napoleon and Snowball leads to the animals taking over the farm. Vowing to eliminate the terrible inequities of the farmyard, the renamed Animal Farm is organised to benefit all who walk on four legs. But as time passes, the ideals of the rebellion are corrupted, then forgotten. And something new and unexpected emerges. . .", null, "Thriller", "https://localhost:5001/images/thriller/AnimalFarm.jpg", "English", 112, 23.149999999999999, "01 Oct 2008", "Penguin Books Ltd", 20, "Animal Farm : The dystopian classic" },
                    { "a259b9a4-e157-4d56-b", " George Orwell", 49, "United Kingdom", "Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101. . .", null, "Thriller", "https://localhost:5001/images/thriller/1984.jpg", "English", 336, 15.289999999999999, "01 Oct 2008", " Penguin Books Ltd", 0, "1984 : The dystopian classic" },
                    { "4a941c80-1730-46d3-a", "Yung Pueblo", 138, "United States", "From poet, meditator, and speaker Yung Pueblo, comes a collection of poetry and prose that explores the movement from self-love to unconditional love, the power of letting go, and the wisdom that comes when we truly try to know ourselves. It serves as a reminder to the reader that healing, transformation, and freedom are possible.", null, "Poetry & Drama", "https://localhost:5001/images/poetry&drama/Inward.jpg", "English", 240, 23.989999999999998, "05 Aug 2020", "Andrews McMeel Publishing", 20, "Inward" },
                    { "3270ace6-237c-409c-8", "Rupi Kaur", 332, "United States", "The book is divided into four chapters, and each chapter serves a different purpose. Deals with a different pain. Heals a different heartache. Milk and Honey takes readers through a journey of the most bitter moments in life and finds sweetness in them because there is sweetness everywhere if you are just willing to look.", null, "Poetry & Drama", "https://localhost:5001/images/poetry&drama/", "English", 208, 2014.0, "08 Jul 2016", "Andrews McMeel Publishing", 208, "Milk and Honey" },
                    { "a839466f-34bb-4e0b-9", "Yung Pueblo", 152, "United States", "In Clarity & Connection, Yung Pueblo describes how intense emotions accumulate in our subconscious and condition us to act and react in certain ways. In his characteristically spare, poetic style, he guides readers through the excavation and release of the past that is required for growth.", null, "Poetry & Drama", "https://localhost:5001/images/poetry&drama/Clarity.jpg", "English", 256, 29.789999999999999, "27 May 2021", "Andrews McMeel Publishing", 5, "Clarity & Connection" },
                    { "36a26a86-538d-447c-a", "Nosy Crow", 781, "United Kingdom", "Little Red Riding Hood sets out into the forest to take a basket of goodies to her poorly grandma. Along the way, she adds to her stores, picking beautiful flowers, gathering fallen acorns and receiving a gift of some nice, sticky honey. She thinks these treats will cheer up her grandma. But little does she know that they could just save her from the Big Bad Wolf . . .", null, "Children's Books", "https://localhost:5001/images/childrenbooks/LittleRedRidingHood.jpg", "English", 32, 18.600000000000001, "31 Dec 2016", "Nosy Crow Ltd", 2, "Fairy Tales: Little Red Riding Hood" },
                    { "293f1b61-3ad2-4d08-8", "Ed Bryan", 651, "United Kingdom", "When Goldilocks gets lost in the woods, she finds herself at a cosy little cottage. She is delighted to find three bowls of porridge on the table, three chairs in the living room and some very bouncy beds in the bedroom. But little does Goldilocks know, this cottage belongs to three bears, and they're on their way back home . . .", null, "Children's Books", "https://localhost:5001/images/childrenbooks/Goldilocks.jpg", "English", 32, 18.600000000000001, "07 Mar 2019", "Nosy Crow Ltd", 12, "Fairy Tales: Goldilocks and the Three Bears" },
                    { "8115ef8e-6561-411f-9", "Ed Bryan", 918, "United Kingdom", "When the wicked queen discovers that her stepdaughter, Snow White, is the most beautiful woman in the land, she orders the huntsman to kill her. But Snow White escapes and finds a wonderful new home living with seven friendly dwarfs in a cosy cottage. That is, until the wicked queen pays a visit . . . It's up to the seven dwarfs and a very kind prince to defeat the queen and help Snow White live happily ever after!", null, "Children's Books", "https://localhost:5001/images/childrenbooks/SnowWhite.jpg", "English", 32, 18.600000000000001, "04 Jul 2019", "Nosy Crow Ltd", 13, "Fairy Tales: Snow White" },
                    { "583e8f45-2706-4030-9", "Bram Stoker", 342, " United Kingdom", "There he lay looking as if youth had been half-renewed, for the white hair and moustache were changed to dark iron-grey, the cheeks were fuller, and the white skin seemed ruby-red underneath; the mouth was redder than ever, for on the lips were gouts of fresh blood, which trickled from the corners of the mouth and ran over the chin and neck. Even the deep, burning eyes seemed set amongst the swollen flesh, for the lids and pouches underneath were bloated. It seemed as if the whole awful creature were simply gorged with blood; he lay like a filthy leech, exhausted with his repletion.", null, "Horror", "https://localhost:5001/images/horror/Dracula.jpg", "English", 532, 10.23, "01 Aug 1997", "Wordsworth Editions Ltd", 3, "Dracula" },
                    { "ca570351-f3ca-403b-9", " Mary Shelley", 491, "United Kingdom", "A twisted, upside-down creation myth, Mary Shelley's chilling Gothic tale lays bare the dark side of science, and the horror within us all. It tells the story of Victor Frankenstein, who plunders graveyards to create a new being from the bodies of the dead - but whose botched creature causes nothing but murder and destruction. Written after a nightmare when its author was only eighteen, Frankenstein gave birth to the modern science fiction novel.", null, "Horror", "https://localhost:5001/images/horror/Frankenstein.jpg", "English", 288, 17.809999999999999, "01 May 2012", "Penguin Books Ltd", 20, "Frankenstein" },
                    { "60b82636-efb3-4419-8", "John Fowles", 604, "United Kingdom", "Withdrawn, uneducated and unloved, Frederick collects butterflies and takes photographs. He is obsessed with a beautiful stranger, art student Miranda. Coming into unexpected money, he buys a remote Sussex house and calmly abducts Miranda, believing she will grow to love him in time. Alone and desperate, Miranda must struggle to understand her captor if she is to gain her freedom...", null, "Horror", "https://localhost:5001/images/horror/Thecollector.jpg", "English", 288, 14.26, "30 Nov 2007", "Vintage Publishing", 0, "The Collector" },
                    { "dd9751c9-3bbd-47b9-8", "Shirley Jackson", 579, "United Kingdom", "Alone in the world, Eleanor is delighted to take up Dr Montague's invitation to spend a summer in the mysterious Hill House. Joining them are Theodora, an artistic 'sensitive', and Luke, heir to the house. But what begins as a light-hearted experiment is swiftly proven to be a trip into their darkest nightmares, and an investigation that one of their number may not survive. Twice filmed as The Haunting, and the inspiration for a 10-part Netflix series, The Haunting of Hill House is a powerful work of slow-burning psychological horror.", null, "Horror", "https://localhost:5001/images/horror/TheHaunting.jpg", "English", 256, 20.309999999999999, "01 Oct 2009", "Penguin Books Ltd", 4, "The Haunting of Hill House" },
                    { "aac45d7d-b6ca-44a4-8", "Lucinda Riley", 391, "United Kingdom", "After the death of her father - Pa Salt, an elusive billionaire who adopted his six daughters from around the globe - Tiggy D'Apliese , trusting her instincts, moves to the remote wilds of Scotland. There she takes a job doing what she loves; caring for animals on the vast and isolated Kinnaird estate, employed by the enigmatic and troubled Laird, Charlie Kinnaird.", null, "Romance", "https://localhost:5001/images/romance/TheMoonSister.jpg", "English", 768, 13.75, "11 Jul 2019", "Pan MacMillan", 5, "The Moon Sister" },
                    { "01ea198d-0362-47ba-b", "Casey Mcquiston", 11, "United States", "What happens when America's First Son falls in love with the Prince of Wales? When his mother became President, Alex Claremont-Diaz was promptly cast as the American equivalent of a young royal. Handsome, charismatic, genius--his image is pure millennial-marketing gold for the White House.There's only one problem: Alex has a beef with the actual prince, Henry, across the pond. And when the tabloids get hold of a photo involving an Alex-Henry altercation, U.S./British relations take a turn for the worse.", null, "Romance", "https://localhost:5001/images/romance/RedWhiteBlue.jpg", "English", 432, 31.0, "14 May 2019", "St Martin's Press", 3, "Red, White & Royal Blue : A Novel" },
                    { "dd3a9329-108d-42d5-a", "Colleen Hoover", 121, "United Kingdom", "Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily's life suddenly seems almost too good to be true.Ryle is assertive, stubborn, maybe even a little arrogant. He`s also sensitive, brilliant, and has a total soft spot for Lily, but Ryle`s complete aversion to relationships is disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder what made him that way in the first place.", null, "Romance", "https://localhost:5001/images/romance/Endswithus.jpg", "English", 384, 19.949999999999999, "02 Aug 2016", "Simon & Schuster Ltd", 4, "It Ends With Us" },
                    { "a4fa28fa-deb6-4b6a-b", "Bret Easton Ellis", 303, "United States", "In American Psycho, Bret Easton Ellis imaginatively explores the incomprehensible depths of madness and captures the insanity of violence in our time or any other. Patrick Bateman moves among the young and trendy in 1980s Manhattan. Young, handsome, and well educated, Bateman earns his fortune on Wall Street by day while spending his nights in ways we cannot begin to fathom. Expressing his true self through torture and murder, Bateman prefigures an apocalyptic horror that no society could bear to confront.", null, "Horror", "https://localhost:5001/images/horror/AmericanPsycho.jpg", "English", 416, 15.130000000000001, "06 Jun 2008", "Random House USA Inc", 0, "American Psycho" },
                    { "d62332ac-db52-4c1a-8", "Casey Mcquiston", 168, "United States", "For cynical twenty-three-year-old August, moving to New York City is supposed to prove her right: that things like magic and cinematic love stories don't exist, and the only smart way to go through life is alone. She can't imagine how waiting tables at a 24-hour pancake diner and moving in with too many weird roommates could possibly change that. And there's certainly no chance of her subway commute being anything more than a daily trudge through boredom and electrical failures.", null, "Romance", "https://localhost:5001/images/romance/Onelaststop.jpg", "English", 432, 24.030000000000001, "01 Jun 2021", "St Martin's Press", 0, "One Last Stop" },
                    { "06f4a297-4c64-444f-a", "Morgan Rogers", 280, "United States", "With her newly completed PhD in astronomy in hand, twenty-eight-year-old Grace Porter goes on a girls' trip to Vegas to celebrate. She's a straight A, work-through-the-summer certified high achiever. She is not the kind of person who goes to Vegas and gets drunkenly married to a woman whose name she doesn't know...until she does exactly that. This one moment of departure from her stern ex-military father's plans for her life has Grace wondering why she doesn`t feel more fulfilled from completing her degree. Staggering under the weight of her parent's expectations, a struggling job market and feelings of burnout, Grace flees her home in Portland for a summer in New York with the wife she barely knows.", null, "Romance", "https://localhost:5001/images/romance/Honeygirl.jpg", "English", 304, 17.84, "23 Feb 2021", "Park Row", 0, "Honey Girl" },
                    { "6fab5d23-8d68-4f27-a", "Lucinda Riley", 264, " United Kingdom", "Following on from the bestselling The Seven Sisters and The Storm Sister, The Shadow Sister is the third book in Lucinda Riley's spellbinding series of love and loss, loosely based on the mythology of the Seven Sisters star cluster.Star D`Apliese is at a crossroads in her life after the sudden death of her beloved father - the elusive billionaire, named Pa Salt by his six daughters, all adopted by him from the four corners of the world. He has left each of them a clue to their true heritage, but Star - the most enigmatic of the sisters - is hesitant to step out of the safety of the close relationship she shares with her sister CeCe. In desperation, she decides to follow the first clue she has been left, which leads her to an antiquarian bookshop in London, and the start of a whole new world . . .", null, "Romance", "https://localhost:5001/images/romance/Theshadowsister.jpg", "English", 720, 21.82, "11 Jul 2019", "Pan MacMillan", 6, "The Shadow Sister" },
                    { "eab713df-7a0e-4657-8", " Rainbow Rowell", 149, "United Kingdom", "Cath and Wren are identical twins, and until recently they did absolutely everything together. Now they're off to university and Wren's decided she doesn't want to be one half of a pair any more - she wants to dance, meet boys, go to parties and let loose. It's not so easy for Cath. She's horribly shy and has always buried herself in the fan fiction she writes, where she always knows exactly what to say and can write a romance far more intense than anything she's experienced in real life.", null, "Romance", "https://localhost:5001/images/romance/Fangirl.jpg", "English", 480, 19.57, "30 Jan 2014", "Pan MacMillan", 20, "Fangirl" },
                    { "d1f76c7a-8383-4c3b-b", " Rainbow Rowell", 264, "United Kingdom", "Eleanor is the new girl in town, and she's never felt more alone. All mismatched clothes, mad red hair and chaotic home life, she couldn't stick out more if she tried. Then she takes the seat on the bus next to Park. Quiet, careful and - in Eleanor's eyes - impossibly cool, Park's worked out that flying under the radar is the best way to get by. Slowly, steadily, through late-night conversations and an ever-growing stack of mix tapes, Eleanor and Park fall in love. They fall in love the way you do the first time, when you're 16, and you have nothing and everything to lose.", null, "Romance", "https://localhost:5001/images/romance/Eleanorpark.jpg", "English", 336, 17.050000000000001, "07 Jul 2014", "Orion Publishing Co", 12, "Eleanor & Park" },
                    { "5ba9c349-f416-40f6-9", "Stephen King", 156, "United States", "Before Doctor Sleep, there was The Shining, a classic of modern American horror from the undisputed master, Stephen King. Jack Torrance's new job at the Overlook Hotel is the perfect chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he'll have plenty of time to spend reconnecting with his family and working on his writing. But as the harsh winter weather sets in, the idyllic location feels ever more remote . . . and more sinister. And the only one to notice the strange and terrible forces gathering around the Overlook is Danny Torrance, a uniquely gifted five-year-old.", null, "Horror", "https://localhost:5001/images/horror/TheShining.jpg", "English", 688, 10.539999999999999, "07 Feb 2020", "Random House USA Inc", 25, "The Shining" },
                    { "cd4d719e-e781-43a0-b", "Stephen King", 160, "United Kingdom", "Derry, Maine is just an ordinary town: familiar, well-ordered for the most part, a good place to live. It is a group of children who see - and feel - what makes Derry so horribly different. In the storm drains, in the sewers, IT lurks, taking on the shape of every nightmare, each one's deepest dread. Sometimes is appears as an evil clown named Pennywise and sometimes IT reaches up, seizing, tearing, killing . . . Time passes and the children grow up, move away and forget. Until they are called back, once more to confront IT as IT stirs and coils in the sullen depths of their memories, emerging again to make their past nightmares a terrible present reality.", null, "Horror", "https://localhost:5001/images/horror/It.jpg", "English", 1184, 17.989999999999998, "21 Jul 2011", "HODDER & STOUGHTON", 21, "It" },
                    { "c5ba0798-68f4-4991-b", "Sally Rooney", 141, "United Kingdom", "Connell and Marianne grow up in the same small town in the west of Ireland, but the similarities end there. In school, Connell is popular and well-liked, while Marianne is a loner. But when the two strike up a conversation - awkward but electrifying - something life-changing begins. Normal People is a story of mutual fascination, friendship and love. It takes us from that first conversation to the years beyond, in the company of two people who try to stay apart but find they can't.", null, "Romance", "https://localhost:5001/images/romance/Normalpoeple.jpg", "English", 288, 19.57, "23 Jul 2019", "FABER & FABER", 2, "Normal People" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "4e65b96e-763b-400c-9", "All Thriller Books", "Thriller" },
                    { "ca8a4bb8-ce3a-4d53-8", "All Fiction Books", "Science Fiction" },
                    { "7ef4182c-f476-4a7d-8", "All Romance Books", "Romance" },
                    { "5f11631e-1043-4005-9", "All Horror  Books", "Horror" },
                    { "e0059d39-df26-4dc9-8", "All Poetry & Drama Books", "Poetry & Drama" },
                    { "85a631c3-12aa-45ea-b", "All Children's Books Books", "Children's Books" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
