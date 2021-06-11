using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class Add_Romance_Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a70a3c56-35d1-403c-a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c3f54c84-e68c-478b-8");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c9f25236-e26b-4049-a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "cf23a14f-4554-41d5-b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "d4406cd7-c789-45df-b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "db2fe0ad-2f7f-4115-9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e001aaa9-3285-4c0b-a");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BestsellerRank", "Country", "Description", "GenreId", "GenreTitle", "ImageUrl", "Language", "Pages", "Price", "PublicationDate", "Publisher", "Quantity", "Title" },
                values: new object[,]
                {
                    { "23c891ac-993d-4d40-9", "Diana Gabaldon", 132, "United States", "Claire Beauchamp Randall and Jamie Fraser, in a spellbinding novel of passion and history that combines exhilarating adventure with a love story for the ages. Scottish Highlands, 1945. Claire Randall, a former British combat nurse, is just back from the war and reunited with her husband on a second honeymoon when she walks through a standing stone in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach--an 'outlander'--in a Scotland torn by war and raiding clans in the year of Our Lord . . . 1743. Claire is catapulted into the intrigues of a world that threatens her life, and may shatter her heart. Marooned amid danger, passion, and violence, Claire learns her only chance of safety lies in Jamie Fraser, a gallant young Scots warrior. What begins in compulsion becomes urgent need, and Claire finds herself torn between two very different men, in two irreconcilable lives.", null, "Romance", "https://localhost:5001/images/romance/Outlander.jpg", "English", 896, 16.18, "01 Aug 1996", "Bantam Doubleday Dell Publishing Group Inc", 30, "Outlander" },
                    { "10d27a42-5066-46ca-a", "Lucinda Riley", 391, "United Kingdom", "After the death of her father - Pa Salt, an elusive billionaire who adopted his six daughters from around the globe - Tiggy D'Apliese , trusting her instincts, moves to the remote wilds of Scotland. There she takes a job doing what she loves; caring for animals on the vast and isolated Kinnaird estate, employed by the enigmatic and troubled Laird, Charlie Kinnaird.", null, "Romance", "https://localhost:5001/images/romance/TheMoonSister.jpg", "English", 768, 13.75, "11 Jul 2019", "Pan MacMillan", 5, "The Moon Sister" },
                    { "6c9a8ac2-0cc4-4f64-8", "Casey Mcquiston", 11, "United States", "What happens when America's First Son falls in love with the Prince of Wales? When his mother became President, Alex Claremont-Diaz was promptly cast as the American equivalent of a young royal. Handsome, charismatic, genius--his image is pure millennial-marketing gold for the White House.There's only one problem: Alex has a beef with the actual prince, Henry, across the pond. And when the tabloids get hold of a photo involving an Alex-Henry altercation, U.S./British relations take a turn for the worse.", null, "Romance", "https://localhost:5001/images/romance/RedWhiteBlue.jpg", "English", 432, 31.0, "14 May 2019", "St Martin's Press", 3, "Red, White & Royal Blue : A Novel" },
                    { "ace19c1e-5e5a-4a1b-9", "Colleen Hoover", 121, "United Kingdom", "Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily's life suddenly seems almost too good to be true.Ryle is assertive, stubborn, maybe even a little arrogant. He`s also sensitive, brilliant, and has a total soft spot for Lily, but Ryle`s complete aversion to relationships is disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder what made him that way in the first place.", null, "Romance", "https://localhost:5001/images/romance/Endswithus.jpg", "English", 384, 19.949999999999999, "02 Aug 2016", "Simon & Schuster Ltd", 4, "It Ends With Us" },
                    { "bc1848dd-5ba0-4d6b-a", "Lucinda Riley", 264, " United Kingdom", "Following on from the bestselling The Seven Sisters and The Storm Sister, The Shadow Sister is the third book in Lucinda Riley's spellbinding series of love and loss, loosely based on the mythology of the Seven Sisters star cluster.Star D`Apliese is at a crossroads in her life after the sudden death of her beloved father - the elusive billionaire, named Pa Salt by his six daughters, all adopted by him from the four corners of the world. He has left each of them a clue to their true heritage, but Star - the most enigmatic of the sisters - is hesitant to step out of the safety of the close relationship she shares with her sister CeCe. In desperation, she decides to follow the first clue she has been left, which leads her to an antiquarian bookshop in London, and the start of a whole new world . . .", null, "Romance", "https://localhost:5001/images/romance/Theshadowsister.jpg", "English", 720, 21.82, "11 Jul 2019", "Pan MacMillan", 6, "The Shadow Sister" },
                    { "e0423cb7-9d7e-427f-a", "Casey Mcquiston", 168, "United States", "For cynical twenty-three-year-old August, moving to New York City is supposed to prove her right: that things like magic and cinematic love stories don't exist, and the only smart way to go through life is alone. She can't imagine how waiting tables at a 24-hour pancake diner and moving in with too many weird roommates could possibly change that. And there's certainly no chance of her subway commute being anything more than a daily trudge through boredom and electrical failures.", null, "Romance", "https://localhost:5001/images/romance/Onelaststop.jpg", "English", 432, 24.030000000000001, "01 Jun 2021", "St Martin's Press", 0, "One Last Stop" },
                    { "bfa7fb8c-2994-408f-b", "Morgan Rogers", 280, "United States", "With her newly completed PhD in astronomy in hand, twenty-eight-year-old Grace Porter goes on a girls' trip to Vegas to celebrate. She's a straight A, work-through-the-summer certified high achiever. She is not the kind of person who goes to Vegas and gets drunkenly married to a woman whose name she doesn't know...until she does exactly that. This one moment of departure from her stern ex-military father's plans for her life has Grace wondering why she doesn`t feel more fulfilled from completing her degree. Staggering under the weight of her parent's expectations, a struggling job market and feelings of burnout, Grace flees her home in Portland for a summer in New York with the wife she barely knows.", null, "Romance", "https://localhost:5001/images/romance/Honeygirl.jpg", "English", 304, 17.84, "23 Feb 2021", "Park Row", 0, "Honey Girl" },
                    { "747ce5ca-01ec-4cf2-8", "Sally Rooney", 141, "United Kingdom", "Connell and Marianne grow up in the same small town in the west of Ireland, but the similarities end there. In school, Connell is popular and well-liked, while Marianne is a loner. But when the two strike up a conversation - awkward but electrifying - something life-changing begins. Normal People is a story of mutual fascination, friendship and love. It takes us from that first conversation to the years beyond, in the company of two people who try to stay apart but find they can't.", null, "Romance", "https://localhost:5001/images/romance/Normalpoeple.jpg", "English", 288, 19.57, "23 Jul 2019", "FABER & FABER", 2, "Normal People" },
                    { "21eee644-7554-44d0-b", " Rainbow Rowell", 149, "United Kingdom", "Cath and Wren are identical twins, and until recently they did absolutely everything together. Now they're off to university and Wren's decided she doesn't want to be one half of a pair any more - she wants to dance, meet boys, go to parties and let loose. It's not so easy for Cath. She's horribly shy and has always buried herself in the fan fiction she writes, where she always knows exactly what to say and can write a romance far more intense than anything she's experienced in real life.", null, "Romance", "https://localhost:5001/images/romance/Fangirl.jpg", "English", 480, 19.57, "30 Jan 2014", "Pan MacMillan", 20, "Fangirl" },
                    { "3fbc718d-06c9-4aa4-b", " Rainbow Rowell", 264, "United Kingdom", "Eleanor is the new girl in town, and she's never felt more alone. All mismatched clothes, mad red hair and chaotic home life, she couldn't stick out more if she tried. Then she takes the seat on the bus next to Park. Quiet, careful and - in Eleanor's eyes - impossibly cool, Park's worked out that flying under the radar is the best way to get by. Slowly, steadily, through late-night conversations and an ever-growing stack of mix tapes, Eleanor and Park fall in love. They fall in love the way you do the first time, when you're 16, and you have nothing and everything to lose.", null, "Romance", "https://localhost:5001/images/romance/Eleanorpark.jpg", "English", 336, 17.050000000000001, "07 Jul 2014", "Orion Publishing Co", 12, "Eleanor & Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "10d27a42-5066-46ca-a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "21eee644-7554-44d0-b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "23c891ac-993d-4d40-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3fbc718d-06c9-4aa4-b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "6c9a8ac2-0cc4-4f64-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "747ce5ca-01ec-4cf2-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ace19c1e-5e5a-4a1b-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bc1848dd-5ba0-4d6b-a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bfa7fb8c-2994-408f-b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "e0423cb7-9d7e-427f-a");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "a70a3c56-35d1-403c-a", "All Fiction Books", "Fiction" },
                    { "d4406cd7-c789-45df-b", "All Fantasy Books", "Fantasy" },
                    { "db2fe0ad-2f7f-4115-9", "All Romance Books", "Romance" },
                    { "e001aaa9-3285-4c0b-a", "All Horror  Books", "Horror" },
                    { "cf23a14f-4554-41d5-b", "All Poetry & Drama Books", "Poetry & Drama" },
                    { "c9f25236-e26b-4049-a", "All Thriller Books", "Thriller " },
                    { "c3f54c84-e68c-478b-8", "All Children's Books Books", "Children's Books" }
                });
        }
    }
}
