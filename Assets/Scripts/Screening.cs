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
    
    public Reservation reserve(Customer customer, int audienceCount) {
        return new Reservation(customer, this, CalculateFee(audienceCount), audienceCount);
    }
    
    public Money GetMovieFee() {
        return Movie.Fee;
    }

    public DateTime GetMovieEndTime() {
        return Movie.GetEndTimeFrom(WhenScreened);
    }

    Money CalculateFee(int audienceCount) {
        return Movie.CalculateMovieFee(this).Times(audienceCount);
    }
}
