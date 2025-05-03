namespace _modul10_103022330077
{
    public class Movies
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Cast { get; set; }
        public string Synopsis { get; set; }

        public Movies(string title, string director, List<string> cast, string synopsis)
        {
            Title = title;
            Director = director;
            Cast = cast;
            Synopsis = synopsis;
        }
    }

}
