using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

            List<Video> videos = new List<Video>();

            Video video01 = new Video("Tutorial for you (Tables)", "DevAcademy", 500);
            video01._commentList.Add(new Comment("User001", "This video is amazing, I undestand my program."));
            video01._commentList.Add(new Comment("CarlosTorres", "You are awesome, now is easy!"));
            video01._commentList.Add(new Comment("Kingmaster", "Great video, thank you!!"));
            videos.Add(video01);

            Video video02 = new Video("Ready for the trip? Now Cancun", "AboutYourCountry", 900);
            video02._commentList.Add(new Comment("Traveler34", "I love the beach, here is 100"));
            video02._commentList.Add(new Comment("TripsAroundTheWorld", "I´m here too!"));
            video02._commentList.Add(new Comment("MomPaty", "My son love the food, i miss the food!"));
            videos.Add(video02);

            Video video03 = new Video("Make your new friend(Amigurumi)", "Crochet for begginers", 1300);
            video03._commentList.Add(new Comment("Rockfriend", "Thank you, now I can make a gift for my gf"));
            video03._commentList.Add(new Comment("Yarnking", "The magic ring was clear, you´re a master!"));
            video03._commentList.Add(new Comment("Patrick345", "Im a  begginer, This is so easy and you explain is easy for me."));
            videos.Add(video03);

            foreach (Video video in videos)
            {
                Console.WriteLine("");
                Console.WriteLine($"TITLE: {video._title}");
                Console.WriteLine($"AUTHOR: {video._author}");
                Console.WriteLine($"LENGTH: {video._length} seconds");
                Console.WriteLine($"COMMENTS: ({video.CommentCount()}):");
                Console.WriteLine("");

                foreach (Comment comment in video._commentList)
                {
                    Console.WriteLine($"> {comment._name}: \"{comment._text}\"");
                }
                Console.WriteLine();
            }

        }
    }
    
}