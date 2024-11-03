using static Assignment;

public class WritingAssignment : Assignment{
	private String _title;

	public WritingAssignment( String t, String n, String to ){
		_title = t;

		setName(n);
		setTopic(to);
	}

	public WritingAssignment( String t ){
		_title = t;
	}

	public String GetWritingInformation(){
		return $"{_title} by {_studentName}";
	}

}