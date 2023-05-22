namespace DesignPatterns.Mediator
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusyWithAircraft = false;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}