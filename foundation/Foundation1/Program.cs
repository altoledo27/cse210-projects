using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("A Beautiful Rendition of I Need Thee Every Hour", "The Church of Jesus Christ of Latter-day Saints", 286);
        Video video2 = new Video("Are You Really There?", "The Church of Jesus Christ of Latter-day Saints", 225);
        Video video3 = new Video("Forgiving Others: An Easter Message from President Russell M. Nelson", "The Church of Jesus Christ of Latter-day Saints", 301);

        // Add comments to each video
        video1.AddComment(new Comment("@Poppyseed20", "I love how at the end, it shows that Emma also needed the Savior and sat in the church with the rest of the people even though she was the one singing. Such beautiful symbolism"));
        video1.AddComment(new Comment("@JamieOttesen", "This is so beautiful. I need this everyday. your voice is so gorgeous. That-you so much!"));
        video1.AddComment(new Comment("@ShaneBrown20", "I like how it showed everyone coming in from their own walk of life experience, and being blessed with tender mercies from the song in their own way."));

        video2.AddComment(new Comment("@brotherwesterldr5085", "Thank you for showing the easily overlooked and silent everyday struggles that Heavenly Father sees. Surely, He is eager to bless those who would simply look to Him and pray. He is there."));
        video2.AddComment(new Comment("@autummnarnell1845", "Welp, I'm a bucket of tears. Thank you for the sweet reminder that God is always there and the simple beautiful change a heartfelt prayer can make. Needed this today. "));
        video2.AddComment(new Comment("@tribalmotor", "I needed to see this.  Thank you, our church's media department is truly inspired."));

        video3.AddComment(new Comment("@chirstoperallen6714", "I'm not Mormon, but I love this man! Thank you President Nelson."));
        video3.AddComment(new Comment("@princessmarin751", "Im not a member of this church! but i love the teachings about the Life of Jesus Christ."));
        video3.AddComment(new Comment("@ErickHansenHaiTech", "The prophet of our times personally knows the importance of forgiveness. What a powerful example!"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the information of each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}