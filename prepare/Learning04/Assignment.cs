using System;


public class Assignment{
	protected String _studentName;
	protected String _topic;

	public Assignment(){}

	public void setName( String n ){
		_studentName = n;
	}

	public void setTopic( String t ){
		_topic = t;
	}


	public String GetSummary(){
		return $"{_studentName} - {_topic}";
	}
}


