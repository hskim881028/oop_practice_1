using System;
using DefaultNamespace;

public class Screening {
    public Movie Movie { get; }
    public int Sequence;
    public DateTime WhenScreened;

    public Screening(Movie movie, int sequence, DateTime whenScreened) {
        Movie = movie;
        Sequence = sequence;
        WhenScreened = whenScreened;
    }
}
