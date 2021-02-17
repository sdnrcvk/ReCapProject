using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            

            while (true)
            {

                Console.WriteLine("\n 1-Add car \n 2-Delete car \n 3-Update car \n 4-List Cars \n 5-Add Brand " +
                    "\n 6-Delete Brand \n 7-Update Brand \n 8-List Brands \n 9-Add Color \n 10-Delete Color \n 11-Update Color \n " +
                    "12-List Colors \n 13-Add Users \n 14-Delete Users \n 15-Update Users \n 16-List Users \n 17-RentalTest \n 18-Exit");
                Console.WriteLine("\nYapmak istediğiniz işlemi seçiniz...");
                var value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choice : " + value + "\n");

                if (0 < value && value < 19)
                {
                    switch (value)
                    {
                        case 1:
                            AddCar(carManager);
                            break;
                        case 2:
                            DeleteCar(carManager);
                            break;
                        case 3:
                            UpdateCar(carManager);
                            break;
                        case 4:
                            ListCars(carManager);
                            break;
                        case 5:
                            AddBrand(brandManager);
                            break;
                        case 6:
                            DeleteBrand(brandManager);
                            break;
                        case 7:
                            UpdateBrand(brandManager);
                            break;
                        case 8:
                            ListBrands(brandManager);
                            break;
                        case 9:
                            AddColor(colorManager);
                            break;
                        case 10:
                            DeleteColor(colorManager);
                            break;
                        case 11:
                            UpdateColor(colorManager);
                            break;
                        case 12:
                            ListColors(colorManager);
                            break;
                        case 13:
                            AddUser(userManager);
                            break;
                        case 14:
                            DeleteUser(userManager);
                            break;
                        case 15:
                            UpdateUser(userManager);
                            break;
                        case 16:
                            ListUsers(userManager);
                            break;
                        case 17:
                            ListRent(rentalManager);
                            break;
                        case 18:
                            Environment.Exit(1);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong choice! Try again...");
                }
            }
        }

        private static void AddCar(CarManager carManager)
        {
            Car car = new Car();

            Console.Write("Brand Id: ");
            car.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nColor Id: ");
            car.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nModelYear: ");
            car.ModelYear = Console.ReadLine();
            Console.Write("\nDailyPrice:");
            car.DailyPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDescription: ");
            car.Description = Console.ReadLine();
            carManager.Add(car);
        }
        private static void DeleteCar(CarManager carManager)
        {
            Car car1 = new Car();
            Console.Write("CarId : ");
            car1.CarId = Convert.ToInt32(Console.ReadLine());

            carManager.Delete(car1);
        }
        private static void UpdateCar(CarManager carManager)
        {
            Car car2 = new Car();

            Console.Write("CarId : ");
            car2.CarId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nBrand Id : ");
            car2.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nColor Id: ");
            car2.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nModelYear: ");
            car2.ModelYear = Console.ReadLine();
            Console.Write("\nDailyPrice:");
            car2.DailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDescription: ");
            car2.Description = Console.ReadLine();

            carManager.Update(car2);
        }
        private static void ListCars(CarManager carManager)
        {
            Console.WriteLine("\nId\tBrand Id\tBrandName\tColor Id\tColor Name\tModel Year\tDaily Price\tDescription");
            Console.WriteLine("______________________________________________________________________________________________________________________\n");
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car3 in result.Data)
                {
                    Console.WriteLine($"{car3.CarId}\t {car3.BrandId}\t\t{car3.BrandName}\t\t {car3.ColorId}\t\t{car3.ColorName}\t\t{car3.ModelYear}\t\t {car3.DailyPrice}\t\t{car3.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void AddBrand(BrandManager brandManager)
        {
            Brand brand = new Brand();
            Console.WriteLine("Brand Id: ");
            brand.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBrand Name: ");
            brand.BrandName = Console.ReadLine();
            brandManager.Add(brand);
        }        
        private static void DeleteBrand(BrandManager brandManager)
        {
            Brand brand = new Brand();
            Console.WriteLine("Brand Id: ");
            brand.BrandId = Convert.ToInt32(Console.ReadLine());

            brandManager.Delete(brand);
        }        
        private static void UpdateBrand(BrandManager brandManager)
        {
            Brand brand1 = new Brand();
            Console.WriteLine("Brand Id: ");
            brand1.BrandName = Console.ReadLine();
            Console.WriteLine("\nBrand Name: ");
            brand1.BrandName = Console.ReadLine();
            brandManager.Update(brand1);
        }
        private static void ListBrands(BrandManager brandManager)
        {

            Console.WriteLine("\nBrand Id\tBrandName");
            Console.WriteLine("_________________________________\n");
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandId + "\t\t" + item.BrandName);
                Console.WriteLine(" ");
            }
        }        
        private static void AddColor(ColorManager colorManager)
        {
            Color color = new Color();
            Console.WriteLine("Color Name: ");
            color.ColorName = Console.ReadLine();
            colorManager.Add(color);
        }
        private static void DeleteColor(ColorManager colorManager)
        {
            Color color = new Color();
            Console.WriteLine("Color Id: ");
            color.ColorId = Convert.ToInt32(Console.ReadLine());

            colorManager.Delete(color);
        }
        private static void UpdateColor(ColorManager colorManager)
        {
            Color color1 = new Color();
            Console.WriteLine("Color Id: ");
            color1.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBrand Name: ");
            color1.ColorName = Console.ReadLine();
            colorManager.Update(color1);
        }
        private static void ListColors(ColorManager colorManager)
        {
            Console.WriteLine("\nColor Id\tColor Name");
            Console.WriteLine("_________________________________\n");
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorId + "\t\t" + item.ColorName);
                Console.WriteLine(" ");
            }
        }
        private static void AddUser(UserManager userManager)
        {
            User us = new User();

            Console.Write("First Name : ");
            us.FirstName = Console.ReadLine();
            Console.Write("\nLast Name : ");
            us.LastName = Console.ReadLine();
            Console.Write("\nEmail : ");
            us.Email = Console.ReadLine();
            Console.Write("\nPassword : ");
            us.Password = Console.ReadLine();

            userManager.Add(us);
        }
        private static void DeleteUser(UserManager userManager)
        {
            User us1 = new User();
            Console.Write("CarId : ");
            us1.Id = Convert.ToInt32(Console.ReadLine());
            userManager.Delete(us1);
        }
        private static void ListUsers(UserManager userManager)
        {
            Console.WriteLine("\nUserId\tFirstN\tLastN\t\tEmail\t\tPassword");
            Console.WriteLine("___________________________________________________________________________\n");
            foreach (User user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.Id +"\t"+ user.FirstName +"\t"+ user.LastName +"\t"+ user.Email +"\t"+ user.Password);
                Console.WriteLine(" ");
            }
        }
        private static void UpdateUser(UserManager userManager)
        {
            User us2 = new User();
            Console.Write("User Id : ");
            us2.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFirst Name : ");
            us2.FirstName = Console.ReadLine();
            Console.Write("\nLast Name : ");
            us2.LastName = Console.ReadLine();
            Console.Write("\nEmail : ");
            us2.Email = Console.ReadLine();
            Console.Write("\nPassword : ");
            us2.Password = Console.ReadLine();

            userManager.Update(us2);
        }
        private static void ListRent(RentalManager rentalManager)
        {
            Console.WriteLine("\nId\tBrandName\tCustomerName\t\tRentDate\tReturnDate");
            Console.WriteLine("_____________________________________________________________________________________\n");
            var result = rentalManager.GetRentalDetailsDto();
            if (result.Success == true)
            {
                foreach (var re in result.Data)
                {
                    Console.WriteLine($"{re.Id}\t{re.BrandName}\t\t{re.CustomerName}\t{re.RentDate}\t{re.ReturnDate}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
