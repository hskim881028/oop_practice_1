using System.Collections.Generic;

public abstract class DiscountPolicy {
    public List<DiscountCondition> Conditions { get; private set; }= new List<DiscountCondition>();

    DiscountPolicy(List<DiscountCondition> conditions) {
        Conditions = conditions;
    }

    public Money CalculateDiscountAmount(Screening screening) {
        CheckPrecondition(screening);
        
        Money money = Money.Create(0);
        foreach (var i in Conditions) {
            if (i.IsSatisfiedBy(screening)) {
                money = GetDiscountAmount(screening);
                CheckPostcondition(money);
                return money;
            }
        }
        
        // money = screening.get
        CheckPostcondition(money);
        return money;
    }

    protected void CheckPrecondition(Screening screening) {
    }

    protected void CheckPostcondition(Money money) {
    }
    
    abstract protected Money GetDiscountAmount(Screening screening);
}