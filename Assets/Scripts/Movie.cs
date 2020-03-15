using System;
using UnityEditor.Experimental.GraphView;

namespace DefaultNamespace
{
    public class Movie {
        public string Title { get; }
        public TimeSpan RunningTime { get; }
        public DiscountPolicy DiscountPolicy { get; }
        public Money Fee { get; }

        public Movie(String title, TimeSpan runningTime, Money fee, DiscountPolicy discountPolicy) {
            Title = title;
            RunningTime = runningTime;
            DiscountPolicy = discountPolicy;
        }

        public Money CalculateMovieFee(Screening screening) {
            return Fee.Minus(DiscountPolicy.CalculateDiscountAmount(screening));
        }

        public DateTime GetEndTimeFrom(DateTime whenStarted) {
            return whenStarted.Add(RunningTime);;
        }
    }
}