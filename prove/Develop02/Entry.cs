using System;

//for getting the date
using System.Globalization;

public class Entry{

	//data for each entry object
	public int _day { get; set; }
	public int _month { get; set; }
	public int _year { get; set; }
	public String _answer { get; set; }
	public int _prompt_index { get; set; }
	
	//got these prompts from chatGPT
	public static List<String> _prompts = new() {

    "What is one thing you're grateful for today?",
    "Describe a recent challenge and how you overcame it.",
    "What is a goal you want to achieve this month?",
    "Write about a book or article that inspired you.",
    "List three things you love about yourself.",
    "What is a skill you want to learn, and why?",
    "Reflect on a happy memory from your childhood.",
    "What is your favorite way to relax after a long day?",
    "If you could travel anywhere right now, where would it be and why?",
    "Write about someone who has had a positive impact on your life.",
    "What is one habit you want to build this week?",
    "Describe a moment when you felt proud of yourself.",
    "What does success look like for you?",
    "Write about a time you took a risk and what you learned from it.",
    "What is something new you want to try this week?",
    "How do you define happiness?",
    "What is a quality you admire in others?",
    "Write a letter to your future self.",
    "What is your favorite way to express creativity?",
    "Describe a situation where you learned from failure.",
    "What do you want to accomplish by the end of this year?"
};

	public DateTime _date;

	//constructor for entry object
	public Entry(){

	}

	//gets the user response along with the date and the index of the random prompt
	public void userResponse(){
		//get the date and save it to int
		refreshDate();
		_day = getDay();
		_month = getMonth();
		_year = getYear();

		//choose from the list of prompts
		Random rand = new Random();
        _prompt_index = rand.Next(0, _prompts.Count());

        //display prompt and get user input
        Console.WriteLine(_prompts[_prompt_index]);
        Console.Write("> ");
        _answer = Console.ReadLine();
		
	}

	//displays info from the entry object
	public void displayResponse(){
		Console.WriteLine($"Date: {_month}/{_day}/{_year} - Prompt: {_prompts[_prompt_index]}");
		Console.WriteLine(_answer);	
	}

	//stuff for getting current date
	//refreshDate gets the current date and sets it to the 
	//day month year attribuites 
	public void refreshDate(){
		_date = DateTime.Now;
	}
	public int getDay(){
		return _date.Day;
	}
	public int getMonth(){
		return _date.Month;
	}
	public int getYear(){
		return _date.Year;
	}
}
