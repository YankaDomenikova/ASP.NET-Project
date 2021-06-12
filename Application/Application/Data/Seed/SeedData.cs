using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Models;

using Microsoft.EntityFrameworkCore;

namespace Application.Data.Seed
{
    public class SeedData
    {
        public ModelBuilder GenerateModels(ModelBuilder modelBuilder)
        {
            List<Genre> genres = new List<Genre>()
            {
                //new Genre { Title=" ", Description="All * Books"},
                new Genre { Title="Science Fiction", Description="All Fiction Books"},
                new Genre { Title="Romance", Description="All Romance Books"},
                new Genre { Title="Horror", Description="All Horror  Books"},
                new Genre { Title="Poetry & Drama", Description="All Poetry & Drama Books"},
                new Genre { Title="Thriller", Description="All Thriller Books"},
                new Genre { Title="Children's Books", Description="All Children's Books Books"},
            };

            List<Book> books = new List<Book>()
            {
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
                    Title="Red, White & Royal Blue",
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
                new Book {
                    Title="The Shining",
                    Author="Stephen King",
                    Description="Before Doctor Sleep, there was The Shining, a classic of modern American horror " +
                    "from the undisputed master, Stephen King. Jack Torrance's new job at the Overlook Hotel is the perfect" +
                    " chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he'll have plenty " +
                    "of time to spend reconnecting with his family and working on his writing. But as the harsh winter weather " +
                    "sets in, the idyllic location feels ever more remote . . . and more sinister. And the only one to notice the" +
                    " strange and terrible forces gathering around the Overlook is Danny Torrance, a uniquely gifted five-year-old.",
                    Price=10.54,
                    Quantity=25,
                    ImageUrl="https://localhost:5001/images/horror/TheShining.jpg",
                    Language="English",
                    Pages=688,
                    PublicationDate="07 Feb 2020",
                    Publisher="Random House USA Inc",
                    Country="United States",
                    BestsellerRank=156,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="It",
                    Author="Stephen King",
                    Description="Derry, Maine is just an ordinary town: familiar, well-ordered for the most part, a good place to live. " +
                    "It is a group of children who see - and feel - what makes Derry so horribly different. In the storm drains, in the sewers," +
                    " IT lurks, taking on the shape of every nightmare, each one's deepest dread. Sometimes is appears as an evil clown named " +
                    "Pennywise and sometimes IT reaches up, seizing, tearing, killing . . . Time passes and the children grow up, move away and " +
                    "forget. Until they are called back, once more to confront IT as IT stirs and coils in the sullen depths of their memories, " +
                    "emerging again to make their past nightmares a terrible present reality.",
                    Price=17.99,
                    Quantity=21,
                    ImageUrl="https://localhost:5001/images/horror/It.jpg",
                    Language="English",
                    Pages=1184,
                    PublicationDate="21 Jul 2011",
                    Publisher="HODDER & STOUGHTON",
                    Country="United Kingdom",
                    BestsellerRank=160,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="The Haunting of Hill House",
                    Author="Shirley Jackson",
                    Description="Alone in the world, Eleanor is delighted to take up Dr Montague's invitation to spend a summer " +
                    "in the mysterious Hill House. Joining them are Theodora, an artistic 'sensitive', and Luke, heir to the house. " +
                    "But what begins as a light-hearted experiment is swiftly proven to be a trip into their darkest nightmares, and an " +
                    "investigation that one of their number may not survive. Twice filmed as The Haunting, and the inspiration for a 10-part " +
                    "Netflix series, The Haunting of Hill House is a powerful work of slow-burning psychological horror.",
                    Price=20.31,
                    Quantity=4,
                    ImageUrl="https://localhost:5001/images/horror/TheHaunting.jpg",
                    Language="English",
                    Pages=256,
                    PublicationDate="01 Oct 2009",
                    Publisher="Penguin Books Ltd",
                    Country="United Kingdom",
                    BestsellerRank=579,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="American Psycho",
                    Author="Bret Easton Ellis",
                    Description="In American Psycho, Bret Easton Ellis imaginatively explores the incomprehensible depths" +
                    " of madness and captures the insanity of violence in our time or any other. Patrick Bateman moves among " +
                    "the young and trendy in 1980s Manhattan. Young, handsome, and well educated, Bateman earns his fortune on Wall Street " +
                    "by day while spending his nights in ways we cannot begin to fathom. Expressing his true self through torture and murder, " +
                    "Bateman prefigures an apocalyptic horror that no society could bear to confront.",
                    Price=15.13,
                    Quantity=0,
                    ImageUrl="https://localhost:5001/images/horror/AmericanPsycho.jpg",
                    Language="English",
                    Pages=416,
                    PublicationDate="06 Jun 2008",
                    Publisher="Random House USA Inc",
                    Country="United States",
                    BestsellerRank=303,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="Frankenstein",
                    Author=" Mary Shelley",
                    Description="A twisted, upside-down creation myth, Mary Shelley's chilling Gothic " +
                    "tale lays bare the dark side of science, and the horror within us all. It tells the story of Victor Frankenstein," +
                    " who plunders graveyards to create a new being from the bodies of the dead - but whose botched creature causes nothing " +
                    "but murder and destruction. Written after a nightmare when its author was only eighteen, Frankenstein gave birth to the" +
                    " modern science fiction novel.",
                    Price=17.81,
                    Quantity=20,
                    ImageUrl="https://localhost:5001/images/horror/Frankenstein.jpg",
                    Language="English",
                    Pages=288,
                    PublicationDate="01 May 2012",
                    Publisher="Penguin Books Ltd",
                    Country="United Kingdom",
                    BestsellerRank=491,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="Dracula",
                    Author="Bram Stoker",
                    Description="There he lay looking as if youth had been half-renewed, for the white hair and moustache were changed " +
                    "to dark iron-grey, the cheeks were fuller, and the white skin seemed ruby-red underneath; the mouth was redder than ever, " +
                    "for on the lips were gouts of fresh blood, which trickled from the corners of the mouth and ran over the chin and neck. " +
                    "Even the deep, burning eyes seemed set amongst the swollen flesh, for the lids and pouches underneath were bloated. It seemed " +
                    "as if the whole awful creature were simply gorged with blood; he lay like a filthy leech, exhausted with his repletion.",
                    Price=10.23,
                    Quantity=3,
                    ImageUrl="https://localhost:5001/images/horror/Dracula.jpg",
                    Language="English",
                    Pages=532,
                    PublicationDate="01 Aug 1997",
                    Publisher="Wordsworth Editions Ltd",
                    Country=" United Kingdom",
                    BestsellerRank=342,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="The Collector",
                    Author="John Fowles",
                    Description="Withdrawn, uneducated and unloved, Frederick collects butterflies and takes photographs. " +
                    "He is obsessed with a beautiful stranger, art student Miranda. Coming into unexpected money, he buys a remote Sussex house " +
                    "and calmly abducts Miranda, believing she will grow to love him in time. Alone and desperate, Miranda must struggle to " +
                    "understand her captor if she is to gain her freedom...",
                    Price=14.26,
                    Quantity=0,
                    ImageUrl="https://localhost:5001/images/horror/Thecollector.jpg",
                    Language="English",
                    Pages=288,
                    PublicationDate="30 Nov 2007",
                    Publisher="Vintage Publishing",
                    Country="United Kingdom",
                    BestsellerRank=604,
                    GenreTitle = "Horror"
                    },
                new Book {
                    Title="Snow White",
                    Author="Ed Bryan",
                    Description="When the wicked queen discovers that her stepdaughter, Snow White, is the most beautiful " +
                    "woman in the land, she orders the huntsman to kill her. But Snow White escapes and finds a wonderful " +
                    "new home living with seven friendly dwarfs in a cosy cottage. That is, until the wicked queen pays a visit . . . " +
                    "It's up to the seven dwarfs and a very kind prince to defeat the queen and help Snow White live happily ever after!",
                    Price=18.60,
                    Quantity=13,
                    ImageUrl="https://localhost:5001/images/childrenbooks/SnowWhite.jpg",
                    Language="English",
                    Pages=32,
                    PublicationDate="04 Jul 2019",
                    Publisher="Nosy Crow Ltd",
                    Country="United Kingdom",
                    BestsellerRank=918,
                    GenreTitle = "Children's Books"
                    },
                new Book {
                    Title="Goldilocks and the Three Bears",
                    Author="Ed Bryan",
                    Description="When Goldilocks gets lost in the woods, she finds herself at a cosy little cottage. She is delighted" +
                    " to find three bowls of porridge on the table, three chairs in the living room and some very bouncy beds in the " +
                    "bedroom. But little does Goldilocks know, this cottage belongs to three bears, and they're on their way back home . . .",
                    Price=18.60,
                    Quantity=12,
                    ImageUrl="https://localhost:5001/images/childrenbooks/Goldilocks.jpg",
                    Language="English",
                    Pages=32,
                    PublicationDate="07 Mar 2019",
                    Publisher="Nosy Crow Ltd",
                    Country="United Kingdom",
                    BestsellerRank=651,
                    GenreTitle = "Children's Books"
                    },
                new Book {
                    Title="Little Red Riding Hood",
                    Author="Nosy Crow",
                    Description="Little Red Riding Hood sets out into the forest to take a basket of goodies to her poorly grandma. " +
                    "Along the way, she adds to her stores, picking beautiful flowers, gathering fallen acorns and receiving a gift " +
                    "of some nice, sticky honey. She thinks these treats will cheer up her grandma. But little does she know that they" +
                    " could just save her from the Big Bad Wolf . . .",
                    Price=18.60,
                    Quantity=2,
                    ImageUrl="https://localhost:5001/images/childrenbooks/LittleRedRidingHood.jpg",
                    Language="English",
                    Pages=32,
                    PublicationDate="31 Dec 2016",
                    Publisher="Nosy Crow Ltd",
                    Country="United Kingdom",
                    BestsellerRank=781,
                    GenreTitle = "Children's Books"
                    },
                new Book {
                    Title="Clarity & Connection",
                    Author="Yung Pueblo",
                    Description="In Clarity & Connection, Yung Pueblo describes how intense emotions accumulate in our subconscious " +
                    "and condition us to act and react in certain ways. In his characteristically spare, poetic style, " +
                    "he guides readers through the excavation and release of the past that is required for growth.",
                    Price=29.79,
                    Quantity=5,
                    ImageUrl="https://localhost:5001/images/poetry&drama/Clarity.jpg",
                    Language="English",
                    Pages=256,
                    PublicationDate="27 May 2021",
                    Publisher="Andrews McMeel Publishing",
                    Country="United States",
                    BestsellerRank=152,
                    GenreTitle = "Poetry & Drama"
                    },
                new Book {
                    Title="Milk and Honey",
                    Author="Rupi Kaur",
                    Description="The book is divided into four chapters, and each chapter serves a different purpose. Deals with a different pain. " +
                    "Heals a different heartache. Milk and Honey takes readers through a journey of the most bitter moments in life and finds sweetness " +
                    "in them because there is sweetness everywhere if you are just willing to look.",
                    Price=2014,
                    Quantity=208,
                    ImageUrl="https://localhost:5001/images/poetry&drama/MilkandHoney.jpg",
                    Language="English",
                    Pages=208,
                    PublicationDate="08 Jul 2016",
                    Publisher="Andrews McMeel Publishing",
                    Country="United States",
                    BestsellerRank=332,
                    GenreTitle = "Poetry & Drama"
                    },
                new Book {
                    Title="Inward",
                    Author="Yung Pueblo",
                    Description="From poet, meditator, and speaker Yung Pueblo, comes a collection of poetry and prose that " +
                    "explores the movement from self-love to unconditional love, the power of letting go, and the wisdom that comes when" +
                    " we truly try to know ourselves. It serves as a reminder to the reader that healing, transformation, and freedom are possible.",
                    Price=23.99,
                    Quantity=20,
                    ImageUrl="https://localhost:5001/images/poetry&drama/Inward.jpg",
                    Language="English",
                    Pages=240,
                    PublicationDate="05 Aug 2020",
                    Publisher="Andrews McMeel Publishing",
                    Country="United States",
                    BestsellerRank=138,
                    GenreTitle = "Poetry & Drama"
                    },
                new Book {
                    Title="1984",
                    Author=" George Orwell",
                    Description="Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out " +
                    "from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that " +
                    "life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and " +
                    "circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not " +
                    "tolerate dissent - even in the mind. For those with original thoughts they invented Room 101. . .",
                    Price=15.29,
                    Quantity=0,
                    ImageUrl="https://localhost:5001/images/thriller/1984.jpg",
                    Language="English",
                    Pages=336,
                    PublicationDate="01 Oct 2008",
                    Publisher=" Penguin Books Ltd",
                    Country="United Kingdom",
                    BestsellerRank=49,
                    GenreTitle = "Thriller"
                    },
                new Book {
                    Title="Animal Farm",
                    Author="George Orwell",
                    Description="Mr Jones of Manor Farm is so lazy and drunken that one day he forgets to feed his livestock. " +
                    "The ensuing rebellion under the leadership of the pigs Napoleon and Snowball leads to the animals taking over the farm. " +
                    "Vowing to eliminate the terrible inequities of the farmyard, the renamed Animal Farm is organised to benefit all who walk on four legs. " +
                    "But as time passes, the ideals of the rebellion are corrupted, then forgotten. And something new and unexpected emerges. . .",
                    Price=23.15,
                    Quantity=20,
                    ImageUrl="https://localhost:5001/images/thriller/AnimalFarm.jpg",
                    Language="English",
                    Pages=112,
                    PublicationDate="01 Oct 2008",
                    Publisher="Penguin Books Ltd",
                    Country="United Kingdom",
                    BestsellerRank=77,
                    GenreTitle = "Thriller"
                    },
                new Book {
                    Title="Artemis",
                    Author="Andy Weir",
                    Description="Jazz Bashara is one of the criminals. She lives in a poor area of Artemis and subsidises" +
                    " her work as a porter with smuggling contraband onto the moon. But it's not enough.So when she's offered " +
                    "the chance to make a lot of money she jumps at it. But though planning a crime in 1/6th gravity may be more fun," +
                    " it's also a lot more dangerous.When you live on the moon, of course you have a dark side...",
                    Price=21.66,
                    Quantity=2,
                    ImageUrl="https://localhost:5001/images/fiction/Artemis.jpg",
                    Language="English",
                    Pages=320,
                    PublicationDate="12 Jul 2018",
                    Publisher="Cornerstone",
                    Country="United Kingdom",
                    BestsellerRank=980,
                    GenreTitle = "Science Fiction"
                    },
                new Book {
                    Title="Ender's Game",
                    Author="Orson Scott Card",
                    Description="Ender's Game is the classic Hugo and Nebula award-winning science fiction novel of a " +
                    "young boy's recruitment into the midst of an interstellar war. In order to develop a secure defense " +
                    "against a hostile alien race's next attack, government agencies breed child geniuses and train them as soldiers. " +
                    "A brilliant young boy, Andrew Ender Wiggin lives with his kind but distant parents, his sadistic brother Peter, " +
                    "and the person he loves more than anyone else, his sister Valentine. Peter and Valentine were candidates for the " +
                    "soldier-training program but didn't make the cut--young Ender is the Wiggin drafted to the orbiting Battle School " +
                    "for rigorous military training.",
                    Price=18.85,
                    Quantity=3,
                    ImageUrl="https://localhost:5001/images/fiction/EndersGame.jpg",
                    Language="English",
                    Pages=375,
                    PublicationDate="30 Nov 1998",
                    Publisher="Tor Books",
                    Country="United States",
                    BestsellerRank=461,
                    GenreTitle = "Science Fiction"
                    },
                new Book {
                    Title="Death's End",
                    Author="Cixin Liu ",
                    Description="Earth enjoys unprecedented prosperity due to the infusion of Trisolaran knowledge and, " +
                    "with human science advancing and the Trisolarans adopting Earth culture, it seems that the two civilizations " +
                    "can co-exist peacefully as equals without the terrible threat of mutually assured annihilation. But peace has " +
                    "made humanity complacent.",
                    Price=27.50,
                    Quantity=20,
                    ImageUrl="https://localhost:5001/images/fiction/DeathsEnd.jpg",
                    Language="English",
                    Pages=608,
                    PublicationDate="04 May 2017",
                    Publisher="Head of Zeus",
                    Country=" United Kingdom",
                    BestsellerRank=166,
                    GenreTitle = "Science Fiction"
                    }
            };

            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Book>().HasData(books);

            return modelBuilder;
        }
    }
}
