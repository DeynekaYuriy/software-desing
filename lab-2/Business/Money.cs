using Business.Interfaces;
using System.ComponentModel;

namespace Business
{

    public class Money : IMoney
    {
        public Currency Currency { get; set; }
        private uint Integer { get; set; }
        private uint Fractional { get; set; }

        public Money(Currency currency, float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Money amount can't be a negative number");
            }
            SetAmount(amount);
            Currency = currency;
        }

        public void Add(float amount)
        {
            var currentAmount = this.GetAmount();
            currentAmount += amount;
            SetAmount(currentAmount);

        }
        public void Subtract(float amount)
        {
            var currentAmount = this.GetAmount();
            currentAmount -= amount;
            SetAmount(currentAmount);
        }

        public float GetAmount()
        {
            var result = (float)Integer;
            result += (float)(Fractional / 100.0);
            return result;

        }

        public void SetAmount(float amount)
        {
            var parts = MoneyUtils.ParseFloat(amount);
            Integer = parts.Item1;
            Fractional = parts.Item2;
        }

        public override string ToString()
        {
            return $"{Integer},{Fractional} {Currency.Sign}";
        }

    }

    public static class MoneyUtils
    {
        public static Tuple<uint, uint> ParseFloat(float amount)
        {
            var integer = (uint)amount;
            var fractional = (uint)((amount % integer) * 100);
            return new Tuple<uint, uint>(integer, fractional);
        }
    }
}