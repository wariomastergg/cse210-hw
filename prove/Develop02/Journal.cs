using System;
using static Entry;

//stuff for saving the files
using System.IO;
using System.Text.Json;

public class Journal{

	public List<Entry> _entries { get; set; }

	//constructor, initiates the list of entries
	public Journal(){
		_entries = new();
	}

	//calls functions from Entry to add entry to journal
	public void addEntry(){
		Entry entry = new Entry();
		entry.userResponse();
		_entries.Add(entry);

	}

	//displays all the entries in order, calls function from Entry
	public void displayEntries(){
		foreach (Entry i in _entries){
			i.displayResponse();
		}
	}


	//saves _entries to json file
	public void writeToFile(String filename){


		//serializeing list to json format
		String jsn = JsonSerializer.Serialize(_entries);
		//write the formatted string to a file with given filename
        using (StreamWriter wfile = new StreamWriter(filename))
        {
            wfile.WriteLine(jsn);
        }

	}

	//reads _entries from json file
	public void readFromFile(String filename){

		//read the formatted list from the json file with given filename
		using (StreamReader rfile = new StreamReader(filename))
        {

            String file = rfile.ReadToEnd();
            //deserialize json info into list
            List<Entry> b = JsonSerializer.Deserialize<List<Entry>>(file);

            //set entries to the deserialized lis of entries
            _entries = b;
        }

	}
	

}