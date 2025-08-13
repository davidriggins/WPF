using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingListToClass
{
    public class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Owner = "Alice", Type = CarType.Sedan, Brand = CarBrand.Audi },
                new Car { Owner = "Bob", Type = CarType.SUV, Brand = CarBrand.Toyota },
                new Car { Owner = "Charlie", Type = CarType.Hatchback, Brand = CarBrand.Ford },
                new Car { Owner = "David", Type = CarType.Sedan, Brand = CarBrand.BMW },
                new Car { Owner = "Eve", Type = CarType.SUV, Brand = CarBrand.Honda },
            };
        }
    }
}
