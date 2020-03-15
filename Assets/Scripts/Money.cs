using System;

public class Money {
    public int Amount { get; }

    Money(int amount) {
        this.Amount = amount;
    }

    public Money Plus(Money money) {
        return new Money(money.Amount + Amount);
    }
    
    public Money Minus(Money money) {
        return new Money(money.Amount - Amount);
    }

    public Money Times(int value) {
        return new Money(Amount * value);
    }

    public bool IsLessThan(Money money) {
        return Amount > money.Amount;
    }
    
    public bool IsGreaterThanOrEqual(Money money) {
        return Amount <= money.Amount;
    }

    public bool Equals(Object obj) {
        return obj.GetHashCode() == this.GetHashCode();
    }

    public string ToString() {
        return Amount.ToString() + "원";
    }
    
    public static Money Create(int amount) {
        return new Money(amount);
    }
}
