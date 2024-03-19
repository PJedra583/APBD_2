using System;
using System.ComponentModel;
using Tutorial3.Properties;

namespace Tutorial3
{
    public class Container : IContainer
    {
        public double CargoWeight { get; set; }
        public double Height { get; set; }

        protected Container(double cargoWeight, double height)
        {
            CargoWeight = cargoWeight;
            Height = height;
        }
        public void Unload()
        {
            throw new NotImplementedException();
        }
        public void load()
        {
            throw new OverfillException();
        }
    }
}
