using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Estacionamento_DIO
{
    internal class Menu
    {

        public Menu() { }
        public int MenuOptions()
        {
            Console.WriteLine(">>>Options<<<".ToUpper());
            Console.WriteLine("1 -> Register a Vehicle");
            Console.WriteLine("2 -> Delete a Vehicle");
            Console.WriteLine("3 -> List Vehicles");
            Console.WriteLine("4 -> Close");
            Console.Write("Option choosed: ");
            int optionChoosed = int.Parse(Console.ReadLine());
            ClearPrompt();
            return optionChoosed;
        }

        public void OptionChoosed(int option)
        {
            Vehicle vehicle;
            List<Vehicle> vList = new List<Vehicle>();
            float temporaryPrice;
            int cont =1;

            do
            {
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        vehicle = new();
                        vehicle.ID = cont;
                        temporaryPrice = vehicle.RegisterHourPrice();

                        Console.WriteLine(">>>Register a Vehicle<<<".ToUpper(), "\n");
                        vehicle.RegisterVehicle();
                        vList.Add(vehicle);
                        vehicle.FinalPrice(temporaryPrice);
                        cont++;
                        ClearPrompt();
                        option = MenuOptions();
                        break;

                    case 2:
                        if (!IsEmpty(vList))
                        {
                            Console.WriteLine(">>>Delete a Vehicle<<<".ToUpper(), "\n");
                            Console.Write("Enter vehicle ID: ");
                            int id = int.Parse(Console.ReadLine());

                            for (int i = 0; i<vList.Count; i++)
                            {
                                if (vList[i].ID == id)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(vList[i].ToString());
                                    vList.Remove(vList[i]);
                                    Console.WriteLine("\nVehicle removed!");
                                }
                            }
                        }
                        else
                            Console.WriteLine("There are no cars in the parking lot!");

                        ClearPrompt();
                        option = MenuOptions();
                        break;

                    case 3:
                        Console.WriteLine(">>>List vehicles<<<".ToUpper(), "\n");

                        foreach (var v in vList)
                        {
                            Console.WriteLine(v.ToString());
                            Console.WriteLine();
                        }

                        ClearPrompt();
                        option = MenuOptions();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Close".ToUpper());

                        ClearPrompt();
                        break;

                    default:
                        Console.WriteLine("\nInvalid option!\n".ToUpper());

                        ClearPrompt();
                        option = MenuOptions();
                        break;
                }
            } while (option != 4);
        }

        private void ClearPrompt()
        {
            Console.WriteLine("\n\nPress ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private bool IsEmpty(List<Vehicle> l)
        {
            bool isEmpty = true;

            if (l.Count != null && l.Count != 0) { isEmpty = false; }

            return isEmpty;
        }
    }
}
