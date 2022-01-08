using System;

namespace AsIsDemo
{
    class Program
    {
        static void ShowAdditionalInfo(Car car)
        {
            if(car is Track)
            {
                Track track = car as Track;
                Console.WriteLine(track.IsWithLoad);
            }
            else if(car is SimpleCar)
            {
                SimpleCar simpleCar = car as SimpleCar;
                Console.WriteLine(simpleCar.SpoilerColor);
            }
        }

        static void Main(string[] args)
        {
            Car car = new Track()
            {
                IsWithLoad = true
            };
            Car anotherCar = new SimpleCar()
            {
                SpoilerColor = "Red"
            };
            ShowAdditionalInfo(car);
        }
    }
}
