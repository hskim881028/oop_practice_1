public class Reservation {
    Customer Customer { get; }
    Screening Screening { get; }
    Money Money { get; }
    int AudienceCount { get; }

    public Reservation(Customer customer, Screening screening, Money money, int audienceCount) {
        Customer = customer;
        Screening = screening;
        Money = money;
        AudienceCount = audienceCount;
    }
}
