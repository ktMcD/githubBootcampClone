/* Create a song collection
 * Create a list that will store music genres
 * Populate the list however you want
 * Create a dictionary that will store the song’s name and genre. 
 * Use the Console window to populate the dictionary
 * Only allow genres that exist in your list
 * Implement re-try logic if the user enters a genre that doesn't exist in the list
 * If you get done early try these
 * Add an option to display the current song collection
 * Add an option to remove a song from the dictionary
 * 
*/

List<string> musicGenres = new List<string>();
musicGenres.Add("Jazz");
musicGenres.Add("Classical");
musicGenres.Add("Grunge");
musicGenres.Add("Electronica");
musicGenres.Add("Dance");
musicGenres.Add("HipHop");
musicGenres.Add("Rap");
musicGenres.Add("Rock-a-Billy");
musicGenres.Add("Contemporary Rock");
musicGenres.Add("Classic Rock");
musicGenres.Add("Alternative");
musicGenres.Add("Pop");
musicGenres.Add("Country & Western");
musicGenres.Add("Folk");
musicGenres.Add("Broadway");

Dictionary<string, string> songs = new Dictionary<string, string>();

Orchestrator();

void Orchestrator()
{
    bool addAnotherSong = true;
    Console.WriteLine("Why not add a song to our music list?");
    while (addAnotherSong)
    {
        string title = "";
        string genre = "";
        title = GetSongTitle();
        genre = GimmeAGenre();
        
        ListGenres();
    }
}

void ListGenres()
{
    Console.WriteLine("Here are the available music genres from which to choose...");
    foreach (string genre in musicGenres)
    {
        Console.WriteLine(genre);
    }

}

string GetSongTitle()
{
    string songTitle = "";
    return songTitle;
}

string GimmeAGenre()
{
    string songGenre = "";
    return songGenre;
}

bool AddOneMore()
{
    bool oneMoreSong = false;
    return oneMoreSong;
}

void AddToDictionary(string title, string genre)
{
    // test if the song/genre key pair exists in the dictionary already
    // we can't have more than one instance of a asong, which would be the key in this dictionary
    // if the pair doesn't exist, then add it
    // if the genre doesn't exist in the genres list, then first add the genre to the list.

}