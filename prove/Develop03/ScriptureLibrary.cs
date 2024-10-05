using System.Security.Cryptography.X509Certificates;
//Exceeding Requierements
public class ScriptureLibrary
{
    private string _scriptureChoiced;
    private string _bookChoiced;
    private int _chapterChoiced;
    private int _startVerseChoiced;
    private int _endVerseChoiced;

    public List<string> _scripturesLibrary = new List<string>{
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.",
            "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.",
            "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.",
            "Remember the worth of souls is great in the sight of God; For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him.",
            "If ye love me, keep my commandments.",
            "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness.",
            "Then the word of the Lord came unto me, saying, Before I formed thee in the belly I knew thee; and before thou camest forth out of the womb I sanctified thee, and I ordained thee a prophet unto the nations."
    };
    public List<string> _books = new List<string> {"Proverbs", "Moses", "2 Nephi", "D&C", "John", "Alma", "Jeremiah"};
    public List<int> _chapter = new List<int>{3, 7, 9, 18, 14, 41, 1};
    public List<int> _startingVerse = new List<int>{5, 18, 28, 10, 15, 10, 4};
    //When the scripture only has one verse, add -1 to the list "_endingVerse"
    public List<int> _endingVerse = new List<int> {6, -1, 29, 11, -1, -1, 5};
    public int GetRandomNumber()
    {
        Random rnd = new Random();
        int n = rnd.Next(0,_scripturesLibrary.Count);
        return n;
    }

    public string GetScripture (int n)
    {
        return _scriptureChoiced = _scripturesLibrary[n];
    }
    public string GetBook (int n)
    {
        return _bookChoiced = _books[n];
    }
    public int GetChapter (int n)
    {
        return _chapterChoiced = _chapter[n];
    }
    public int GetStartVerse(int n)
    {
        return _startVerseChoiced = _startingVerse[n];
    }
    public int GetEndVerse(int n)
    {
        return _endVerseChoiced = _endingVerse[n];
    }
}