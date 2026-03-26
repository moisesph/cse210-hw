using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        /////////////////////////////CREATING VIDEOS//////////////////////////////////////////

        List<Video> allVideos = new List<Video>();

        string v1Title = "How breath";
        string v1Author = "Link";
        double v1Length = 98.4;
        List<Comment> v1Comments = new List<Comment>();


        string v1com1Author = "Pepito";
        string V1com1text = "Wow, that was crazy, but I still don't know how to breath";
        Comment v1Com1 = new Comment(v1com1Author, V1com1text);
        v1Comments.Add(v1Com1);

        string v1com2Author = "Xxx_VirusSniper34HD_xxX";
        string V1com2text = "Free Gems in CR! https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        Comment v1Com2 = new Comment(v1com2Author, V1com2text);
        v1Comments.Add(v1Com2);

        string v1com3Author = "Chicken Little";
        string V1com3text = "First!";
        Comment v1Com3 = new Comment(v1com3Author, V1com3text);
        v1Comments.Add(v1Com3);


        Video v1 = new Video(v1Title, v1Author, v1Length, v1Comments);
        allVideos.Add(v1);



        string v2Title = "Funny Videos Don't laugh";
        string v2Author = "ElRubius";
        double v2Length = 12.50;
        List<Comment> v2Comments = new List<Comment>();


        string v2com1Author = "Woody";
        string V2com1text = "I'm a tree-mendous programmer!";
        Comment v2Com1 = new Comment(v2com1Author, V2com1text);
        v2Comments.Add(v2Com1);

        string v2com2Author = "Barnaby";
        string V2com2text = "I'm just here to bee myself.";
        Comment v2Com2 = new Comment(v2com2Author, V2com2text);
        v2Comments.Add(v2Com2);

        string v2com3Author = "Neil";
        string V2com3text = "I need more space, I'm feeling a bit eclipse-d.";
        Comment v2Com3 = new Comment(v2com3Author, V2com3text);
        v2Comments.Add(v2Com3);


        Video v2 = new Video(v2Title, v2Author, v2Length, v2Comments);
        allVideos.Add(v2);



        string v3Title = "Speedrun Super Mario Bros";
        string v3Author = "Suigi";
        double v3Length = 14.35;
        List<Comment> v3Comments = new List<Comment>();


        string v3com1Author = "Stella";
        string V3com1text = "Suigi doesn't just collect stars, he's basically a superstar-ting to break physics!";
        Comment v3Com1 = new Comment(v3com1Author, V3com1text);
        v3Comments.Add(v3Com1);

        string v3com2Author = "Step-hen";
        string V3com2text = "Who needs an elevator when you can just jump backwards into the future?";
        Comment v3Com2 = new Comment(v3com2Author, V3com2text);
        v3Comments.Add(v3Com2);

        string v3com3Author = "Mac";
        string V3com3text = "Why did the computer show up late to the speedrun? Because it had a hard drive!";
        Comment v3Com3 = new Comment(v3com3Author, V3com3text);
        v3Comments.Add(v3Com3);


        Video v3 = new Video(v3Title, v3Author, v3Length, v3Comments);
        allVideos.Add(v3);

        /////////////////////////////SHOWING//////////////////////////////////////////

        Console.WriteLine("Youtube");
        foreach (Video v in allVideos)
        {
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine($"{v.DisplayVideoInfo()}\n------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{v.DisplayVideoComments()}\n");
        }


    }
}