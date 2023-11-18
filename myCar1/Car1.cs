using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCar1
{
    class Car1
    {
        public string color;
        public string name;
        public int maxspeed;
        public int year;
    }
    public Car1(string nameName, string colorName, int maxspeedValue, int yearValue)
    {
        name = nameName;
        color = colorName;
        year = yearValue;
        maxSpeed = maxspeedValue;
    }
    public void fullThrottle()
    {
        Console.WriteLine(name + "is going at the speed of" + maxSpeed);
    }



}
