public class Movies
{
    public string movieName;
    public string genre;
    private string ratings; // makes the variable private (encapsulation)

    public Movies(string AmovieName, string Agenre, string Aratings)
    {

        movieName = AmovieName;
        genre = Agenre;
        Ratings = Aratings; // Setting the Ratings here

    }

    public string Ratings
    {
        get { return ratings; } // This is return the ratings if called
        set
        {
            if (value == "PG" || value == "PG-13" || value == "NR") // Will only be set if these condtions are met
            {
                ratings = value;

            }
            else
            {
                ratings = "NR";
            }
        }
    }

}