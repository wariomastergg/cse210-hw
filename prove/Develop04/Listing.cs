using System;

class Listing : Activity{

    private List<String> _prompts = new(){
        "Tell me about your day.",
        "What are your favorite hobbies?",
        "How do you feel about the current situation?",
        "What are your career goals?",
        "What did you have for lunch today?" };

    public Listing(){
        _activity_name = "Reflection Activity";
        _activity_desctipt = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public String getRPrompt(){
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count())];
    }

    public void readPrompt(){
        Console.Clear();
        Console.WriteLine("List as many responses as possible to the following prompt:");
        Console.WriteLine($"--- {getRPrompt()} ---");
        Console.Write("you may begin in: ");
        countDown(5);
        Console.Write("\n");
    }

    public void userPrompts(){
        DateTime endTime = DateTime.Now.AddSeconds(_activity_time);
        DateTime currentTime = DateTime.Now;
        int items = 0;
        while (currentTime < endTime){
            Console.Write("> ");
            Console.ReadLine();
            items++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"you listed {items} item(s)!");
    }

    public void listingSession(){
        Welcome();
        getReady();
        readPrompt();
        userPrompts();
        wellDone();
    }

}