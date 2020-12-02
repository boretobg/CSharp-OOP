using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private ICollection<IComponent> components;
        private ICollection<IPeripheral> peripherals;

        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : 
            base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => (IReadOnlyCollection<IComponent>)components;

        public IReadOnlyCollection<IPeripheral> Peripherals => (IReadOnlyCollection<IPeripheral>)peripherals;

        public void AddComponent(IComponent component)
        {
            foreach (var item in Components)
            {
                if (item.GetType() == component.GetType())
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.ExistingComponent, component.GetType(), this.GetType(), this.Id));
                }
            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            foreach (var item in Peripherals)
            {
                if (item.GetType() == peripheral.GetType())
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType(), this.GetType(), this.Id));
                }
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (components.Count == 0 && components.Any(c => c.GetType().Name == componentType))
            {
                throw new ArgumentException
                    (string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType(), this.Id));
            }

            var toRemove = components.First(c => c.GetType().Name == componentType);
            components.Remove(toRemove);
            return toRemove;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Count == 0 && peripherals.Any(c => c.GetType().Name == peripheralType))
            {
                throw new ArgumentException
                    (string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType(), this.Id));
            }

            var toRemove = peripherals.First(c => c.GetType().Name == peripheralType);
            peripherals.Remove(toRemove);
            return toRemove;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($" Components ({Components.Count}):");
            foreach (var component in Components)
            {
                sb.AppendLine($"  {component}");
            }

            sb.AppendLine($" Peripherals ({Peripherals.Count}); Average Overall Performance ({peripherals}):"); //TODO: peripherals   
            foreach (var peripheral in Peripherals)
            {
                sb.AppendLine($"  {peripheral}");
            }

            return sb.ToString().Trim();
        }
    }
}
