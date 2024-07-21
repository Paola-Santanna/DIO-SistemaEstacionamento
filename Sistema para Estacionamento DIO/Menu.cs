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
            Console.WriteLine(">>>Menu<<<".ToUpper());
            Console.WriteLine("1 -> Cadastrar um veículo");
            Console.WriteLine("2 -> Remover veículo");
            Console.WriteLine("3 -> Listar veículos");
            Console.WriteLine("4 -> Encerrar");
            Console.Write("Opcao escolhida: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            ClearPrompt();
            return opcaoEscolhida;
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

                        Console.WriteLine(">>>Cadastrar um veículo<<<".ToUpper(), "\n");
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
                            Console.WriteLine(">>>Remover veículo<<<".ToUpper(), "\n");
                            Console.Write("Insira o ID do veículo: ");
                            int id = int.Parse(Console.ReadLine());

                            for (int i = 0; i<vList.Count; i++)
                            {
                                if (vList[i].ID == id)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(vList[i].ToString());
                                    vList.Remove(vList[i]);
                                    Console.WriteLine("\nVeículo removido!");
                                }
                            }
                        }
                        else
                            Console.WriteLine("Nao tem carros no estacionamento!");

                        ClearPrompt();
                        option = MenuOptions();
                        break;

                    case 3:
                        Console.WriteLine(">>>Listar veículos<<<".ToUpper(), "\n");

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
                        Console.WriteLine("Encerrar".ToUpper());

                        ClearPrompt();
                        break;

                    default:
                        Console.WriteLine("\nOpcao Invalida!\n".ToUpper());

                        ClearPrompt();
                        option = MenuOptions();
                        break;
                }
            } while (option != 4);
        }

        private void ClearPrompt()
        {
            Console.WriteLine("\n\nPressione ENTER para prosseguir...");
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
