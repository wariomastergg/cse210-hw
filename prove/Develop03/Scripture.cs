using System;
using System.Linq;
using static Text;

public class Scripture{



    private List<String> _scriptures = new(){
        "The Lord is my shepherd, I shall not want. He makes me lie down in green pastures, he leads me beside still waters. He restores my soul, he leads me in paths of righteousness for his name's sake.",
        "I can do all things through Christ who strengthens me.",
        "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future.",
        "Those who hope in the Lord will renew their strength, they will soar on wings like eagles; they will run and not grow weary, they will walk and not faint.",
        "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
        "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.",
        "Have I not commanded you? Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God is with you wherever you go.",
        "But seek first his kingdom and his righteousness, and all these things will be added to you.",
        "Love is patient, love is kind. Love does not envy, does not boast, it is not proud. It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. Love does not delight in evil but rejoices with the truth. It always protects, always trusts, always hopes, always perseveres.",  
        "I will lift up my eyes to the hills. From whence comes my help? My help comes from the Lord, the Maker of heaven and earth."

    };

    private List<String> _verses = new(){
        "Psalm 23:1-4",
        "Philippians 4:13",
        "Jeremiah 29:11",
        "Isaiah 40:31",
        "John 3:16",
        "Romans 8:28",
        "Joshua 1:9",
        "Matthew 6:33",
        "1 Corinthians 13:4-8",
        "Psalm 121:1-2"
    };

    private int _index;
    private Text _chosen;
    private List<int> _blanked;

    //i added getters and setters because the "encapsulation" part of the assignment probably needed it

    //getters
    public int GetScriptureIndex(){return _index;}
    public Text GetTextObject(){return _chosen;}
    public List<int> GetBlanked(){return _blanked;}

    //setters
    public void SetScriptureIndex( int i ){_index = i;}
    public void SetTextObject( Text t ){_chosen  = t;}
    public void SetBlanked( List<int> b ){_blanked = b;}



    //scripture constructor
    public Scripture(){
        _index = selectScripture();
        _chosen = new Text(_scriptures[_index]);
        _blanked = new();
    }

    //display the scripture without any blanks
    public String display(){
        return $"{_verses[_index]} {_scriptures[_index]}";
    }

    //choose the index of a scripture randomly 
    public int selectScripture(){
        Random rand = new Random();
        return rand.Next(0, _scriptures.Count());
    }

    //randomly choose 1-3 words to blank and retun as a string
    public String produceBlanks(){
        Random rand = new Random();
        List<int> b = new();
        
        bool ful = true;
        for (int i = 0; i <= rand.Next(0, 3); i++){
            int n = rand.Next(0, _chosen.getNumWords());
            while (_blanked.Contains(n)){


                ful = true;
                for (int o = 0; o < _chosen.getNumWords(); o++){
                    if (!_blanked.Contains(o)){
                        ful = false;
                    }
                    if ( ful &&  o >= _chosen.getNumWords()-1 ){
                        _end = true;
                        return $"{_verses[_index]} {_chosen.BlankWords(_blanked)}";
                    }
                }

                n = rand.Next(0, _chosen.getNumWords());
            }
            _blanked.Add( n ); 
        }

        return $"{_verses[_index]} {_chosen.BlankWords(_blanked)}";
    }

    
    


}