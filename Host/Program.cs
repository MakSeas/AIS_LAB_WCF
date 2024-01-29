using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Хост WCF";

            //ServiceHost host = new ServiceHost(typeof(CarCostCalculator));
            //Uri adress = new Uri("http://localhost:8733/Design_Time_Addresses/Host/CarCostCalculator/");
            //BasicHttpBinding binding = new BasicHttpBinding();
            //Type contract = typeof(ICarCostCalculatable);
            //host.AddServiceEndpoint(contract, binding, adress);

            //ShowHostInfo(host);

            //StartHost(host);

            //Console.ReadLine();

            //StopHost(host);
            //Console.ReadLine();

        }

        //static void ShowHostInfo(ServiceHost host)
        //{
        //    Console.WriteLine("******Данные о хосте******\n");
        //    foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
        //    {
        //        Console.WriteLine("Конечная точка: {0}", se.Name);
        //        Console.WriteLine("- Адрес: {0}", se.Address);
        //        Console.WriteLine("- Привязка: {0}", se.Binding.Name);
        //        Console.WriteLine("- Контракт: {0}\n", se.Contract.Name);
        //    }
        //}

        //static void StartHost(ServiceHost host)
        //{
        //    host.Open();
        //    Console.WriteLine("Хост открыт!");
        //}

        //static void StopHost(ServiceHost host)
        //{
        //    host.Close();
        //    Console.WriteLine("Хост закрыт!");
        //}
    }
}
