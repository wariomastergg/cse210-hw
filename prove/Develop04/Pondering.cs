using System;

class Pondering : Activity{
    private List<String> _prompts = new(){
        "Tell me about your day.",
        "What are your favorite hobbies?",
        "How do you feel about the current situation?",
        "What are your career goals?",
        "What did you have for lunch today?" };

    private List<String> _follow_up_prompts = new(){
        "Why do you enjoy that activity?",
        "Can you elaborate on that?",
        "What made you feel that way?",
        "What steps are you taking to achieve those goals?",
        "Would you recommend that dish to others?" };

    private int _index = 0;

    public Pondering(){
        _activity_name = "Pondering Activity";
        _activity_desctipt = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public String getRPrompt(){
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count())];
    }

    public String getRFolPrompt(){
        Random rand = new Random();
        return _follow_up_prompts[rand.Next(0, _follow_up_prompts.Count())];
    }
    
    public void initialPrompt(){
        Console.WriteLine($"\nconsider the foloowing prompt\n\n--- {getRPrompt()} ---");
        Console.Write($"\nif you have something in mind press enter to continue");
        Console.ReadLine();
        Console.Write("\nnow ponder the question\n\nyou may begin in: ");
        countDown(5);
    }

    public void secondPrompt(){
        Console.Clear();
        int steps = ((_activity_time-(_activity_time%5))/5);
        for (int i = 0; i < steps; i++){
            Console.Write($"> {getRFolPrompt()}");
            dial(5);
            Console.Write("\n");
        }
        if (_activity_time%5 > 0){
            Console.Write($"> {getRFolPrompt()}");
            dial(_activity_time%5);
        }
        Console.Write("\n\n");
    }

    public void ponderingSession(){
        Welcome();
        getReady();
        initialPrompt();
        secondPrompt();
        wellDone();
    }
}