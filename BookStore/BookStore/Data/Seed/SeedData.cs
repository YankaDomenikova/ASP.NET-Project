using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Models;

using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Seed
{
    public class SeedData
    {
        public ModelBuilder GenerateModels(ModelBuilder modelBuilder)
        {
            List<Genre> genres = new List<Genre>()
            {
                //new Genre { Title=" ", Description="All * Books"},
                new Genre { Title="Fiction", Description="All Fiction Books"},
                new Genre { Title="Fantasy", Description="All Fantasy Books"},
                new Genre { Title="Romance", Description="All Romance Books"},
                new Genre { Title="Horror", Description="All Horror  Books"},
                new Genre { Title="Poetry & Drama", Description="All Poetry & Drama Books"},
                new Genre { Title="Thriller ", Description="All Thriller Books"},
                new Genre { Title="Children's Books", Description="All Children's Books Books"},
            };

            List<Book> books = new List<Book>()
            {
                //new Book {
                //    Title="",
                //    Author="",
                //    Description="",
                //    Price=, 
                //    Quantity=, 
                //    ImageUrl="https://localhost:5001/images/", 
                //    Language="English", 
                //    Pages=, 
                //    PublicationDate="", 
                //    Publisher="", 
                //    Country="", 
                //    BestsellerRank=,
                //    GenreTitle = ""
                //    },
                new Book {
                    Title="Outlander",
                    Author="Diana Gabaldon",
                    Description="Claire Beauchamp Randall and Jamie Fraser, in a spellbinding novel of passion " +
                    "and history that combines exhilarating adventure with a love story for the ages. " +
                    "Scottish Highlands, 1945. Claire Randall, a former British combat nurse, is just back from " +
                    "the war and reunited with her husband on a second honeymoon when she walks through a standing stone " +
                    "in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach--an 'outlander'--in a" +
                    " Scotland torn by war and raiding clans in the year of Our Lord . . . 1743. Claire is catapulted into the intrigues " +
                    "of a world that threatens her life, and may shatter her heart. Marooned amid danger, passion, and violence, Claire learns her only chance of safety lies " +
                    "in Jamie Fraser, a gallant young Scots warrior. What begins in compulsion becomes urgent need, and Claire finds herself torn between two very different men, in two irreconcilable lives.",
                    Price=16.18,
                    Quantity=30,
                    ImageUrl="https://localhost:5001/images/romance/Outlander.jpg",
                    Language="English",
                    Pages=896,
                    PublicationDate="01 Aug 1996",
                    Publisher="Bantam Doubleday Dell Publishing Group Inc",
                    Country="United States",
                    BestsellerRank=132,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="The Moon Sister",
                    Author="Lucinda Riley",
                    Description="After the death of her father - Pa Salt, an elusive billionaire who adopted his six daughters" +
                    " from around the globe - Tiggy D'Apliese , trusting her instincts, moves to the remote wilds of Scotland. There she takes" +
                    " a job doing what she loves; caring for animals on the vast and isolated Kinnaird estate, employed by the enigmatic and troubled Laird, " +
                    "Charlie Kinnaird.",
                    Price=13.75,
                    Quantity=5,
                    ImageUrl="https://localhost:5001/images/romance/TheMoonSister.jpg",
                    Language="English",
                    Pages=768,
                    PublicationDate="11 Jul 2019",
                    Publisher="Pan MacMillan",
                    Country="United Kingdom",
                    BestsellerRank=391,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="Red, White & Royal Blue : A Novel",
                    Author="Casey Mcquiston",
                    Description="What happens when America's First Son falls in love with the Prince of Wales? " +
                    "When his mother became President, Alex Claremont-Diaz was promptly cast as the American equivalent of a young royal. " +
                    "Handsome, charismatic, genius--his image is pure millennial-marketing gold for the White House.There's only one problem: " +
                    "Alex has a beef with the actual prince, Henry, across the pond. And when the tabloids get hold of a photo involving an " +
                    "Alex-Henry altercation, U.S./British relations take a turn for the worse.",
                    Price =31,
                    Quantity=3,
                    ImageUrl="https://localhost:5001/images/romance/RedWhiteBlue.jpg",
                    Language="English",
                    Pages=432,
                    PublicationDate="14 May 2019",
                    Publisher="St Martin's Press",
                    Country="United States",
                    BestsellerRank=11,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="It Ends With Us",
                    Author="Colleen Hoover",
                    Description="Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. " +
                    "She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, " +
                    "and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything" +
                    " in Lily's life suddenly seems almost too good to be true.Ryle is assertive, stubborn, maybe even a little arrogant. " +
                    "He`s also sensitive, brilliant, and has a total soft spot for Lily, but Ryle`s complete aversion to relationships is " +
                    "disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder " +
                    "what made him that way in the first place.",
                    Price=19.95,
                    Quantity=4,
                    ImageUrl="https://localhost:5001/images/romance/Endswithus.jpg",
                    Language="English",
                    Pages=384,
                    PublicationDate="02 Aug 2016",
                    Publisher="Simon & Schuster Ltd",
                    Country="United Kingdom",
                    BestsellerRank=121,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="The Shadow Sister",
                    Author="Lucinda Riley",
                    Description="Following on from the bestselling The Seven Sisters and The Storm Sister, " +
                    "The Shadow Sister is the third book in Lucinda Riley's spellbinding series of love and loss, loosely based on" +
                    " the mythology of the Seven Sisters star cluster.Star D`Apliese is at a crossroads in her life after the sudden " +
                    "death of her beloved father - the elusive billionaire, named Pa Salt by his six daughters, all adopted by him from " +
                    "the four corners of the world. He has left each of them a clue to their true heritage, but Star - the most enigmatic " +
                    "of the sisters - is hesitant to step out of the safety of the close relationship she shares with her sister CeCe. " +
                    "In desperation, she decides to follow the first clue she has been left, which leads her to an antiquarian bookshop " +
                    "in London, and the start of a whole new world . . .",
                    Price=21.82,
                    Quantity=6,
                    ImageUrl="https://localhost:5001/images/romance/Theshadowsister.jpg",
                    Language="English",
                    Pages=720,
                    PublicationDate="11 Jul 2019",
                    Publisher="Pan MacMillan",
                    Country=" United Kingdom",
                    BestsellerRank=264,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="One Last Stop",
                    Author="Casey Mcquiston",
                    Description="For cynical twenty-three-year-old August, moving to New York City is supposed " +
                    "to prove her right: that things like magic and cinematic love stories don't exist, and the only " +
                    "smart way to go through life is alone. She can't imagine how waiting tables at a 24-hour pancake diner " +
                    "and moving in with too many weird roommates could possibly change that. And there's certainly no chance " +
                    "of her subway commute being anything more than a daily trudge through boredom and electrical failures.",
                    Price=24.03,
                    Quantity=0,
                    ImageUrl="https://localhost:5001/images/romance/Onelaststop.jpg",
                    Language="English",
                    Pages=432,
                    PublicationDate="01 Jun 2021",
                    Publisher="St Martin's Press",
                    Country="United States",
                    BestsellerRank=168,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="Honey Girl",
                    Author="Morgan Rogers",
                    Description="With her newly completed PhD in astronomy in hand, twenty-eight-year-old Grace Porter goes o" +
                    "n a girls' trip to Vegas to celebrate. She's a straight A, work-through-the-summer certified high achiever. " +
                    "She is not the kind of person who goes to Vegas and gets drunkenly married to a woman whose name she doesn't know..." +
                    "until she does exactly that. This one moment of departure from her stern ex-military father's plans for her life has " +
                    "Grace wondering why she doesn`t feel more fulfilled from completing her degree. Staggering under the weight of her" +
                    " parent's expectations, a struggling job market and feelings of burnout, Grace flees her home in Portland for a summer " +
                    "in New York with the wife she barely knows.",
                    Price=17.84,
                    Quantity=0,
                    ImageUrl="https://localhost:5001/images/romance/Honeygirl.jpg",
                    Language="English",
                    Pages=304,
                    PublicationDate="23 Feb 2021",
                    Publisher="Park Row",
                    Country="United States",
                    BestsellerRank=280,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="Normal People",
                    Author="Sally Rooney",
                    Description="Connell and Marianne grow up in the same small town in the west of Ireland, " +
                    "but the similarities end there. In school, Connell is popular and well-liked, while Marianne is a loner. " +
                    "But when the two strike up a conversation - awkward but electrifying - something life-changing begins. " +
                    "Normal People is a story of mutual fascination, friendship and love. It takes us from that first conversation " +
                    "to the years beyond, in the company of two people who try to stay apart but find they can't.",
                    Price=19.57,
                    Quantity=2,
                    ImageUrl="https://localhost:5001/images/romance/Normalpoeple.jpg",
                    Language="English",
                    Pages=288,
                    PublicationDate="23 Jul 2019",
                    Publisher="FABER & FABER",
                    Country="United Kingdom",
                    BestsellerRank=141,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="Fangirl",
                    Author=" Rainbow Rowell",
                    Description="Cath and Wren are identical twins, and until recently they did absolutely everything together. " +
                    "Now they're off to university and Wren's decided she doesn't want to be one half of a pair any more - " +
                    "she wants to dance, meet boys, go to parties and let loose. It's not so easy for Cath. She's horribly shy and " +
                    "has always buried herself in the fan fiction she writes, where she always knows exactly what to say and can write " +
                    "a romance far more intense than anything she's experienced in real life.",
                    Price=19.57,
                    Quantity=20,
                    ImageUrl="https://localhost:5001/images/romance/Fangirl.jpg",
                    Language="English",
                    Pages=480,
                    PublicationDate="30 Jan 2014",
                    Publisher="Pan MacMillan",
                    Country="United Kingdom",
                    BestsellerRank=149,
                    GenreTitle = "Romance"
                    },
                new Book {
                    Title="Eleanor & Park",
                    Author=" Rainbow Rowell",
                    Description="Eleanor is the new girl in town, and she's never felt more alone. All mismatched clothes, " +
                    "mad red hair and chaotic home life, she couldn't stick out more if she tried. Then she takes the seat on the bus next to Park." +
                    " Quiet, careful and - in Eleanor's eyes - impossibly cool, Park's worked out that flying under the radar is the best way to " +
                    "get by. Slowly, steadily, through late-night conversations and an ever-growing stack of mix tapes, Eleanor and Park fall in " +
                    "love. They fall in love the way you do the first time, when you're 16, and you have nothing and everything to lose.",
                    Price =17.05,
                    Quantity=12,
                    ImageUrl="https://localhost:5001/images/romance/Eleanorpark.jpg",
                    Language="English",
                    Pages=336,
                    PublicationDate="07 Jul 2014",
                    Publisher="Orion Publishing Co",
                    Country="United Kingdom",
                    BestsellerRank=264,
                    GenreTitle = "Romance"
                    },

            };

            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Book>().HasData(books);

            return modelBuilder;
        }
    }
}
