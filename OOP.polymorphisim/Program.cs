namespace OOP.polymorphisim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3 class - car biznescar economcar luxcar
            property - masin nomresi ,marka, model, ili, 1gun ucun qiymeti,masn aktiv olub olmamasi
            1. rent a car sahibi kimi daxil olma
              1-masin elave et-secim olacaq econom yoxsa digerleri
              2-masinlara bax-1 ekonom 2 business 3 lux hansina gore baxrsansa
              3-masin silme(masn nomresne gore)

            2. musteri kimi daxil ol
              business masnlar listi
              hansi kateqoriya secse sirf o kateqoriya gosterilsin
              daha sonra nomresin secsin 
              secilmis nomre listden silincek

            Müştəri maşını seçərkən gün daxil etməldir.
            Yəni neçə gün üçün kirayələmək istəyir. 
            Gün daxil etdikdə daxil etdiyi günü maşınının bir günə olan qiymətinə vurub göstərmək lazımdır.
            Qiyməti gördükdən sonra əşgər ki seçsə maşını bu zaman maşın listdən silinə bilər.
            */

            Car car = new Car();
            BusinessCar businessCar = new BusinessCar();
            EconomCar economCar = new EconomCar();
            LuxCar luxCar = new LuxCar();
            while (true)
            {
                Console.WriteLine("Masin sahibi kimi daxil ol - 1");
                Console.WriteLine("Musteri kimi daxil ol - 2");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Masin elave et - 1");
                        Console.WriteLine("Masinlara bax - 2");
                        Console.WriteLine("Masini nomreye gore silme - 3");
                        int rentNum = int.Parse(Console.ReadLine());
                        switch (rentNum)
                        {
                            case 1:
                                Console.WriteLine("1-Ekonom");
                                Console.WriteLine("2-Business");
                                Console.WriteLine("3-Lux");
                                int typeNum = int.Parse(Console.ReadLine());
                                if (typeNum == 1)
                                    economCar.AddCar(economCar.GetCarData());
                                else if (typeNum == 2)
                                    businessCar.AddCar(businessCar.GetCarData());
                                else if (typeNum == 3)
                                    luxCar.AddCar(luxCar.GetCarData());
                                else
                                    Console.WriteLine("1 2 3 daxil et.");
                                break;
                            case 2:
                                Console.WriteLine("1-Ekonom");
                                Console.WriteLine("2-Business");
                                Console.WriteLine("3-Lux");
                                int getCarsNum = int.Parse(Console.ReadLine());
                                if (getCarsNum == 1)
                                {
                                    var myEconomCars = economCar.GetAllCars();
                                    foreach (var item in myEconomCars)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"{item.CarNumber}, {item.Brand} ,{item.Model} ,{item.Year} ,{item.PriceForOneDay} ,{item.IsActive}");
                                    }
                                }
                                else if (getCarsNum == 2)
                                {
                                    var myBusinessCars = businessCar.GetAllCars();
                                    foreach (var item in myBusinessCars)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"{item.CarNumber}, {item.Brand} ,{item.Model} ,{item.Year} ,{item.PriceForOneDay} ,{item.IsActive}");
                                    }
                                }
                                else if (getCarsNum == 3)
                                {
                                    var myLuxCars = luxCar.GetAllCars();
                                    foreach (var item in myLuxCars)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"{item.CarNumber}, {item.Brand} ,{item.Model} ,{item.Year} ,{item.PriceForOneDay} ,{item.IsActive}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("1 2 3 daxil et.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("1-Ekonom");
                                Console.WriteLine("2-Business");
                                Console.WriteLine("3-Lux");
                                int deleteNum = int.Parse(Console.ReadLine());
                                if (deleteNum == 1)
                                {
                                    Console.WriteLine("Masin nömrəsini daxil edin: ");
                                    bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                                    if (tryDelete)
                                        economCar.DeleteCar(carNum);
                                    else
                                        Console.WriteLine("Bele masin tapilmadi");
                                }
                                else if (deleteNum == 2)
                                {
                                    Console.WriteLine("Masin nömrəsini daxil edin: ");
                                    bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                                    if (tryDelete)
                                        businessCar.DeleteCar(carNum);
                                    else
                                        Console.WriteLine("Bele masin tapilmadi");
                                }
                                else if (deleteNum == 3)
                                {
                                    Console.WriteLine("Masin nömrəsini daxil edin: ");
                                    bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                                    if (tryDelete)
                                        luxCar.DeleteCar(carNum);
                                    else
                                        Console.WriteLine("Bele masin tapilmadi");
                                }
                                else
                                {
                                    Console.WriteLine("1 2 3 daxil et.");
                                }
                                break;
                            default:
                                Console.WriteLine("1 2 3 daxil et");
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Baxmaq istediyin kateqoriyani sec");
                        Console.WriteLine("1-Ekonom");
                        Console.WriteLine("2-Business");
                        Console.WriteLine("3-Lux");
                        int getCars = int.Parse(Console.ReadLine());
                        if (getCars == 1)
                        {
                            var myEconomCars = economCar.GetAllCars();
                            foreach (var item in myEconomCars)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"masin nomresi: {item.CarNumber}, markasi: {item.Brand} ,modeli: {item.Model} ,ili: {item.Year} ,1 gunluk qiymeti: {item.PriceForOneDay} ,aktivliyi: {item.IsActive}");
                            }
                            Console.WriteLine("Secmek istediyin masinin nömrəsini daxil edin: ");
                            bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                            Console.WriteLine("Nece gunluk kiraye istediyinizi daxil edin: ");
                            bool tryNum = int.TryParse(Console.ReadLine(), out int selectDay);
                            foreach (var item in myEconomCars)
                            {
                                if (tryDelete && tryNum && item.IsActive == true)
                                {
                                    if (carNum == item.CarNumber)
                                        Console.WriteLine($"{selectDay} gun kiraye qiymeti: {selectDay * item.PriceForOneDay} ");
                                    Console.WriteLine("Secmek isteyirsenmi?");
                                    bool check = Convert.ToBoolean(Console.ReadLine());
                                    if (check)
                                        economCar.DeleteCar(carNum);
                                }
                                else
                                    Console.WriteLine("Bele masin tapilmadi");
                            }
                        }
                        else if (getCars == 2)
                        {
                            var myBusinessCars = businessCar.GetAllCars();
                            foreach (var item in myBusinessCars)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"masin nomresi: {item.CarNumber}, markasi: {item.Brand} ,modeli: {item.Model} ,ili: {item.Year} ,1 gunluk qiymeti: {item.PriceForOneDay} ,aktivliyi: {item.IsActive}");
                            }
                            Console.WriteLine("Secmek istediyin masinin nömrəsini daxil edin: ");
                            bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                            Console.WriteLine("Nece gunluk kiraye istediyinizi daxil edin: ");
                            bool tryNum = int.TryParse(Console.ReadLine(), out int selectDay);
                            foreach (var item in myBusinessCars)
                            {
                                if (tryDelete && tryNum && item.IsActive == true)
                                {
                                    if (carNum == item.CarNumber)
                                        Console.WriteLine($"{selectDay} gun kiraye qiymeti: {selectDay * item.PriceForOneDay} ");
                                    economCar.DeleteCar(carNum);
                                }
                                else
                                    Console.WriteLine("Bele masin tapilmadi");
                            }
                        }
                        else if (getCars == 3)
                        {
                            var myLuxCars = luxCar.GetAllCars();
                            foreach (var item in myLuxCars)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"masin nomresi: {item.CarNumber}, markasi: {item.Brand} ,modeli: {item.Model} ,ili: {item.Year} ,1 gunluk qiymeti: {item.PriceForOneDay} ,aktivliyi: {item.IsActive}");
                            }
                            Console.WriteLine("Secmek istediyin masinin nömrəsini daxil edin: ");
                            bool tryDelete = int.TryParse(Console.ReadLine(), out int carNum);
                            Console.WriteLine("Nece gunluk kiraye istediyinizi daxil edin: ");
                            bool tryNum = int.TryParse(Console.ReadLine(), out int selectDay);
                            foreach (var item in myLuxCars)
                            {
                                if (tryDelete && tryNum && item.IsActive == true)
                                {
                                    if (carNum == item.CarNumber)
                                        Console.WriteLine($"{selectDay} gun kiraye qiymeti: {selectDay * item.PriceForOneDay} ");
                                    economCar.DeleteCar(carNum);
                                }
                                else
                                    Console.WriteLine("Bele masin tapilmadi");
                            }
                        }
                        else
                            Console.WriteLine("1 2 3 daxil et.");
                        break;
                    default:
                        Console.WriteLine(" 1 ve ya 2 sec");
                        break;
                }
            }
        }
    }
    public class Car
    {
        public int CarNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double PriceForOneDay { get; set; }
        public bool IsActive { get; set; }

        public List<Car> cars = new List<Car>();
        public virtual void AddCar(Car cars)
        {

        }
        public List<Car> GetAllCars()
        {
            return cars;
        }
        public void DeleteCar(int number)
        {
            var removeCar = cars.Find(x => x.CarNumber == number);
            cars.Remove(removeCar);
        }
        public Car GetCarData()
        {
            Console.WriteLine("Masin nomresin daxil et");
            int carNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Masin markasini daxil et");
            string brand = Console.ReadLine();
            Console.WriteLine("Masin modelin daxil et");
            string model = Console.ReadLine();
            Console.WriteLine("Masin ilini daxil et");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Masinin 1 gunluk kirayesinin qiymetini daxil et");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Masinin aktivliyini daxil et");
            bool isActive = Convert.ToBoolean(Console.ReadLine());


            return new Car
            {
                CarNumber = carNumber,
                Brand = brand,
                Model = model,
                Year = year,
                PriceForOneDay = price,
                IsActive = isActive
            };
        }
    }
    public class BusinessCar : Car
    {
        public override void AddCar(Car cars)
        {
            this.cars.Add(cars);
        }

    }
    public class EconomCar : Car
    {
        public override void AddCar(Car cars)
        {
            this.cars.Add(cars);
        }

    }
    public class LuxCar : Car
    {
        public override void AddCar(Car cars)
        {
            this.cars.Add(cars);
        }

    }
}
