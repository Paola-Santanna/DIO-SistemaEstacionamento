using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Sistema_para_Estacionamento_DIO
{
    public class Vehicle
    {
        public string VehicleType { get; set; }
        public string VehicleModel { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
        public string LicensePlate { get; set; }
        public int ID { get; set; }
        public int TotalHorsParked { get; set; }
        public float FinalPriceToPay { get; set; }

        public Vehicle()
        {
        }

        private Vehicle(string vehicleType, string vehicleModel, int year, string color, string owner, string licensePlate)
        {
            this.ID = 0;
            this.VehicleType = vehicleType;
            this.VehicleModel = vehicleModel;
            this.Year = year;
            this.Color = color;
            this.Owner = owner;
            this.LicensePlate = licensePlate;
            this.TotalHorsParked = 0;
            this.FinalPriceToPay = 0;
        }

        public float RegisterHourPrice()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Bem vindo ao estacionamento!<<<".ToUpper());
            
            Console.WriteLine("Digite o preço por hora (Use vírgula para decimais)");
            float pricePerHour = float.Parse(Console.ReadLine());

            return pricePerHour;
        }

        public void RegisterVehicle()
        {
            Console.WriteLine("\nInsira as seguintes informações:");

            Console.WriteLine($"\nID: {this.ID}");
            Console.Write("Tipo do veículo: ");
            this.VehicleType = Console.ReadLine();

            Console.Write("Modelo do veículo: ");
            this.VehicleModel = Console.ReadLine();

            Console.Write("Ano do veículo: ");
            this.Year = int.Parse(Console.ReadLine());

            Console.Write("Cor do veículo: ");
            this.Color = Console.ReadLine();

            Console.Write("Proprietário do veículo: ");
            this.Owner = Console.ReadLine();

            Console.Write("Placa do veículo: ");
            this.LicensePlate = Console.ReadLine();
        }

        public void FinalPrice(float p)
        {
            Console.Write("\nTotal de HORAS que o veículos ficou estacionado: ");
            this.TotalHorsParked = int.Parse(Console.ReadLine());

            this.FinalPriceToPay = p*this.TotalHorsParked;

            Console.WriteLine($"\nPreço Por Hora: {p} \nPreço Final: {this.FinalPriceToPay}");
        }

        public override string? ToString()
        {
            return $"ID do Veículo: {this.ID} \nTipo de Veículo: {this.VehicleType} \nModelo do Veículo: {this.VehicleModel} \nAno: {this.Year} \nCor: {this.Color} \nProprietário: {this.Owner} \nPlaca: {this.LicensePlate} \nTotal de Horas Estacionado: {this.TotalHorsParked} \nPreço Final a Pagar: {this.FinalPriceToPay}";
        }
    }
}
