using System;
using static Job;

public class Resume{
	
	private String name;
	private List<Job> jobs = new();

	public Resume(String n, List<Job> j){
		name = n;
		jobs = j;
	}

	public void Display(){
		Console.WriteLine($"name: {name}\njobs:");
		foreach (Job i in jobs){
			i.Display();
		}
		
	}

}