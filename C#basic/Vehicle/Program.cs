using System;

namespace Vehicle
{
    class Program
    {
        class Vehicle {

            public int PRICE;
            public int YEAR;
            public int SPEED;

            public Vehicle(int price, int year, int speed) {
                PRICE = price;
                YEAR = year;
                SPEED = speed;
                    
            }

        }

        class Car {
            public  Car(int price, int year, int speed) {
                Vehicle car = new Vehicle(price, year, speed);
                Console.WriteLine($"Машина: цена- {car.PRICE}$, год выпуска- {car.YEAR} год, скорость- {car.SPEED}км/ч");
            }

        }
        class Plane
        {
            public int PASSANGER, HIGHEST;
            public Plane(int price, int year, int speed, int passanger, int highest)
            {
                HIGHEST = highest;
                PASSANGER = passanger;
                Vehicle plane = new Vehicle(price, year, speed);
                Console.WriteLine($"Самолет: цена- {plane.PRICE}$, год выпуска- {plane.YEAR} год, скорость- {plane.SPEED}км/ч, пассажиры- {passanger}, высота- {1500}м");
            }
        }
        class Ship
        {
            public int PASSANGER;
            public string PORT;
            public Ship(int price, int year, int speed,int passanger, string port)
            {
                PORT = port;
                PASSANGER = passanger;
                Vehicle ship = new Vehicle(price, year, speed);
                Console.WriteLine($"Лодка: цена- {ship.PRICE}$, год выпуска- {ship.YEAR} год, скорость- {ship.SPEED}км/ч, пассажиры- {passanger}, порт регистрации- {port}");
            }

        }
       
        static void Main(string[] args)
        {
            Car audi = new Car(9000, 2021, 220);
            Plane airBus = new Plane(1000000, 2015, 800, 120, 800);
            Ship ship = new Ship(1500000, 2019, 100, 500, "Port Royal");
            
            Console.ReadKey();
        }
    }
}
