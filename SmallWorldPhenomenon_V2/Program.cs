namespace SmallWorldPhenomenon_V2
{
    class Program
    {
        public static void Main(string[] args)
        {
           var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
          
            //Paths to all files are found in the Paths static class

            //Path naming is self-explanatory e.g. MEDIUM_1, LARGE, etc...
            //If a movie file has two queries then a number is added to the end of query name

            //Just change the following two parameters

            Parser.ReadMovieFile(Paths.SAMPLE);
            Parser.ReadQueryFile(Paths.SAMPLE_QUERY);

            //Graph.PrintActorMap();
            //Graph.PrintMovieLink();
            
            
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }
    }
}