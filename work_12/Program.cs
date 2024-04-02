namespace work_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = new Bus("Sari", 2002, 50);
            vehicles[1] = new Car("Qara", 2014, "BMW", "F10", 260);
            vehicles[2] = new Car("Goy", 2022, "AUDI", "Q7", 300);
            vehicles[3] = new Car("Qara", 2012, "OPEL", "Insignia", 260);
            foreach (var Vehicle in vehicles)
            {
                Vehicle.ShowInfo();
            }




        }
    }
}
