using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Factory
    /// </summary>
    internal class Factory
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        public static Factory[] GetFactories()
        {
            return new Factory[] {
            new Factory { Id = 1, Name = "НПЗ№1", Description = "Первый нефтеперерабатывающий завод" },
            new Factory { Id = 2, Name = "НПЗ№2", Description = "Второй нефтеперерабатывающий завод" } 
            };
        }
        public static Factory FindFactory(Factory[] factories, Units unit)
        {
            if (unit == null)
            {
                return null;
            }

            foreach (var factory in factories)
            {
                if (factory.Id == unit.FactoryId)
                {
                    return factory;
                }
            }
            return null;
        }


    }
}
