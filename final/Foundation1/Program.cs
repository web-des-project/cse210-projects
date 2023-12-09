using System;

class Program
{
    static void Main(string[] args)
    {   

        Video video1 = new("&TEAM 'Under the skin'", "HYBE LABELS", 296);
        video1.AddComment(new Comment("@ElabueloconSwag", "You guys are so talented!!"));
        video1.AddComment(new Comment("@Mimi", "I'm proud of &TEAM! This is an amazing song, congratulations on your debut!"));
        video1.AddComment(new Comment("@Angie02", "So proud of each member of the group"));

        Video video2 = new("ENHYPEN 'Go big or go home'", "ENHYPEN", 202);
        video2.AddComment(new Comment("@DianaKim", "I love this music!"));
        video2.AddComment(new Comment("@Winter97", "We need more songs like this one"));
        video2.AddComment(new Comment("@Sharon", "the instrumental is so good"));

        Video video3 = new("Stray Kids 'I am YOU'", "JYP Entertainment", 258);
        video3.AddComment(new Comment("@Jojjo", "4 years later and I still get goosebumps listening to this song, love it!"));
        video3.AddComment(new Comment("@KarenLiz", "Their vocals really shine in this, simply amazing"));
        video3.AddComment(new Comment("@roo2503", "The rap line in this song is so ICONIC"));

        List<Video> videos = new() { video1, video2, video3};

        foreach (Video video in videos)
        {
            video.GetVideoInfo();
            Console.WriteLine();
        }

        




        
    }
}