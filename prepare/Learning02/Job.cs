using System;


//Keeps track of the company, job title, start year, and end year.
public class Job{

	private String company;
	private String job_title;
	private int start_year;
	private int end_year;

	public Job(String c, String t, int s, int e){
		company = c;
		job_title = t;
		start_year = s;
		end_year = e;
	}

	public void Display(){
		Console.WriteLine($"{company} ({job_title}) {start_year}-{end_year}");
	}
}