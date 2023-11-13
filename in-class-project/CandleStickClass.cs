using System;

namespace in_class_project
{
    public class CandleStick
    {
        public DateTime date { get; set; }
        public decimal open { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }
        public decimal volume { get; set; }

        public CandleStick(DateTime date, decimal open, decimal high, decimal low, decimal close, int volume)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }
    }

    public class SmartCandleStick : CandleStick
    {
        public decimal bodyRange { get; private set; }
        public decimal totalRange { get; private set; }
        public decimal range { get; private set; }
        public decimal topPrice { get; private set; }
        public decimal bottomPrice { get; private set; }
        public decimal topTail { get; private set; }
        public decimal bottomTail { get; private set; }

        public SmartCandleStick(DateTime date, decimal open, decimal high, decimal low, decimal close, int volume)
            : base(date, open, high, low, close, volume)
        {
            bodyRange = Math.Abs(open - close);
            totalRange = Math.Abs(high - low);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            topTail = high - Math.Max(open, close);
            bottomTail = Math.Min(open, close) - low;
        }

        public bool IsDoji()
        {
            // Doji is a candlestick with a small body, indicating indecision in the market
            return bodyRange <= 0.1m * totalRange;
        }


        public bool IsMarubozu()
        {
            // Marubozu is a candlestick with no or very small shadows and a long body
            return Math.Abs(open - close) >= 0.9m * totalRange;
        }

        public bool IsBullish()
        {
            // Define your criteria for a Bullish candlestick
            return close > open - 1m;
        }

        public bool IsBearish()
        {
            // Define your criteria for a Bearish candlestick
            return close < open + 1m;
        }

        public bool IsNeutral()
        {
            // Define your criteria for a Neutral candlestick
            return bodyRange <= 0.1m * totalRange;
        }

        // Add methods for other candlestick patterns as needed...

        // Example: Dragonfly Doji
        public bool IsDragonflyDoji()
        {
            // Define your criteria for a Dragonfly Doji
            return IsDoji() && bottomTail < 1m * totalRange;
        }

        // Example: Gravestone Doji
        public bool IsGravestoneDoji()
        {
            // Define your criteria for a Gravestone Doji
            return IsDoji() && topTail < 0.1m * totalRange;
        }

        // Example: Hammer
        public bool IsHammer()
        {
            // Define your criteria for a Hammer
            return  (bottomTail >= 2 * bodyRange) && (topTail <= 0.1m * totalRange);
        }

        // Example: Inverted Hammer
        public bool IsInvertedHammer()
        {
            // Define your criteria for an Inverted Hammer
            return  (topTail >= 2 * bodyRange) && (bottomTail <= 0.1m * totalRange);
        }
    }
}