using System;
using System.Collections.Generic;


// My Quick Web Search:
// https://stackoverflow.com
// https://www.geeksforgeeks.org
// w3schools c#
// MDN
// learn.microsoft.com


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("Introduction to Programming", "CodeMaster", 600);
        video1.AddComment(new Comment("User123", "Great video, very helpful!"));
        video1.AddComment(new Comment("TechGuru", "Thanks for the tutorial!"));
        video1.AddComment(new Comment("ProgrammingNovice", "I learned a lot from this video!"));

        Video video2 = new Video("Data Structures Explained", "AlgorithmExpert", 900);
        video2.AddComment(new Comment("ComputerScienceFan", "Excellent explanation!"));
        video2.AddComment(new Comment("DataWhiz", "Really cleared up my doubts!"));
        video2.AddComment(new Comment("CSStudent", "Helped me prepare for my exam!"));

        Video video3 = new Video("Object-Oriented Programming Concepts", "OOPMaster", 750);
        video3.AddComment(new Comment("OOPEndeavor", "Fantastic overview of OOP!"));
        video3.AddComment(new Comment("Coder123", "This video made OOP concepts easy to understand."));
        video3.AddComment(new Comment("JavaDev", "Very informative, thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };


        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }

    }
}

// Define the Comment class
class Comment
{
    public string _commenterName;
    public string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}


// Define the Video class
class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

