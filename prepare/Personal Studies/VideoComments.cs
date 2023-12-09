using System;
using System.Collections.Generic;
public class VideoComment : Video
{
    private string _name;
    private string _text;
    private int _numberOfComment;

    private  List<Video> _videos = new List<Video>();
    private List<List<string>> _comments = new List<List<string>>();

    public VideoComment(string title, string author, double time, string name, string text) : base(title, author,time)
    {
        _name = name;
        _text = text;
        _numberOfComment = 0;
    }

     public void RunProgram()
    {
        Console.WriteLine("Welome to the 'ABSTRACTION' Program\n");
        int userChoice = 0;

        while(userChoice != 4)
        {
            Console.WriteLine("Option Menu:");
            Console.WriteLine("  1. Create a Video.\n  2. Veiw Videos\n  3. Comment on a Video\n  4. Quit Program");

            Console.Write("Select an Option number to proceed: ");
            string input = Console.ReadLine();

            userChoice = int.Parse(input);

            if(userChoice == 1)
            {
                CreatVideo();
            }
            else if(userChoice == 2)
            {
                ViewVideos();
            }
            else if(userChoice == 3)
            {
                Comments();
            }
            else if(userChoice == 4)
            {
                Console.WriteLine("\nProgram has ended...\n");
            }
            else
            {
                Console.WriteLine("\nWrong Entry Try again!!!\n");
            }
        }
       
    }

    public override void ViewVideos()
    {
        int numb = 0;
        Console.WriteLine("\n..Available Videos..");
        
        foreach (Video v in _videos)
        {
            numb ++;
            Console.WriteLine($"{numb}...{v.GetVideoDetails()}\n");
        }
    }

    public void DisplayDelay()
    {
        Console.Write("Loading Please Wait...");
        for(int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        };
        Console.Clear();     
    }

    public override void CreatVideo()
    {
        Console.Write("What is the Video Title? ");
        string title = Console.ReadLine();
        Console.Write("Who is the Video Author? ");
        string author = Console.ReadLine();
        Console.Write("How long is the video in minutes? ");
        string time = Console.ReadLine();
     
        VideoComment video = new VideoComment(title,author,double.Parse(time),_name,_text);
        _videos.Add(video);
        _comments.Add(new List<string>());

    }
   
    public override void Comments()
    {
        int vidNumber;
        Console.WriteLine("Options:\n  1. View Comment\n  2. Write Comment");
        Console.Write("Select an Option: ");

        string userInput = Console.ReadLine();

        if(int.Parse(userInput) == 1)
        {
            Console.Clear();
            ViewVideos();
            Console.Write("Which video will you like to View it's Comments(select the video number): ");
            string videoNumb = Console.ReadLine();
            vidNumber = int.Parse(videoNumb);

            Console.Clear();
            DisplayDelay();

            if (vidNumber <= _videos.Count && vidNumber > 0)
            {
                Console.WriteLine(_videos[vidNumber - 1].GetVideoDetails());
                foreach (string comment in _comments[vidNumber - 1])
                {
                    Console.WriteLine(comment);
                }
            }
            else
            {
                Console.WriteLine($"Invalid video number. Please select a valid video.");
            }

            Console.WriteLine($"Total Number of comments: {_comments[vidNumber - 1].Count}");
        }
        else if(int.Parse(userInput) == 2)
        {
            Console.Write("Please enter your name: ");
            _name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"\nHello __{_name}__");

            DisplayDelay();
            Console.Clear();
            ViewVideos();

            Console.Write("Which video will you like to Comment on (select the video number): ");
            string videoNumb = Console.ReadLine();
            vidNumber = int.Parse(videoNumb);

            if(vidNumber <= _videos.Count && vidNumber > 0)
            {
                              
                Console.Write("Comment: ");
                _text = Console.ReadLine();
                _numberOfComment ++; 

                string comment =$"\nName: {_name}\nComment: {_text}\n"; 
                _comments[vidNumber-1].Add(comment);
                           
            }
            else
            {
                Console.WriteLine("Item not found in the list.");
            }

        }
        else
        {
            Console.Write("WRONG INPUT!!");
        }

    }
}

