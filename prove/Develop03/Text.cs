using System;
using System.Linq;


public class Text{

	private String _text;
	private List<String> _words = new();

	//i added getters and setters because the "encapsulation" part of the assignment probably needed it

	//getters
	public String GetText(){return _text;}
	public List<String> GetWords(){return _words;}

	//setters
	public void GetText(String s){_text = t;}
	public void GetWords(List<String> w){_words = w;}


	public int getNumWords(){
		return _words.Count();
	}


	public Text(String t){
		_text = t;
		_words = t.Split( ' ' ).ToList();

	}

	public Text(){}

	//returns a string containing the input string but the lettrs a-z (not case sensitive) are underscores
	public String ReturnAsBlank(String s){
		String abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

		String c = "";
		foreach (char l in s){
			if ( abc.Contains(l) ){
				c = $"{c}{"_"}";
			}
			else{
				c = $"{c}{l}";
			}
		}

		return c;
	}

	//a list of the word indicies to blank is input, and the corrosponding words in _words are blanked and that is returned as a string
	public String BlankWords(List<int> b){
		String c = "";
		Text t = new Text();
		for (int i = 0; i < _words.Count(); i++){
			if ( b.Contains(i) ){
				
				c = $"{c}{ t.ReturnAsBlank(_words[i]) } ";
			}
			else{
				c = $"{c}{ _words[i] } ";
			}
		}
		return c;
	}


}