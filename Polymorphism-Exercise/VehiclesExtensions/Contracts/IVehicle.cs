namespace VehiclesExtensions.Contracts
{
    public interface IVehicle
    {
        public abstract double FuelQuantity { get; }
        public abstract double FuelConsumption { get; }
        public double TankCapacity { get; }

        public void Drive(double distance);
        public void Refuel(double distance);
    }
}
