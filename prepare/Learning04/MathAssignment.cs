using static Assignment;

public class MathAssignment : Assignment{
	private String _textbookSection;
	private String _problems;

	public MathAssignment( String s, String p, String n, String t){
		_textbookSection = s;
		_problems = p;

		setName(n);
		setTopic(t);
	}

	public MathAssignment( String s, String p){
		_textbookSection = s;
		_problems = p;
	}

	public String GetHomeworkList(){
		return $"Section {_textbookSection} Prolems {_problems}";
	}
}