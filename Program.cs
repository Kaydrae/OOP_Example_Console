using System;

namespace OOP_Example_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int userChoice = 0;
            Smart_Lamp smartlamp = new Smart_Lamp();
            Smart_Lock smartlock = new Smart_Lock();

            do
            {
                 Console.WriteLine("Welcome to the OOP Console Example.");
                            Console.WriteLine("Which Device would you like to add?");
                            Console.WriteLine("1. Smart Lock");
                            Console.WriteLine("2. Smart Lamp");
                            userChoice = Convert.ToInt16(Console.ReadLine());
                            
                            if (userChoice == 1)
                            {
                                Console.WriteLine("Smart Lock Has been selected.");
                                addSmartLock(smartlock);
                            }

                            if (userChoice == 2)
                            {
                                Console.WriteLine("Smart Lamp Has been selected.");
                                addSmartLamp(smartlamp);
                            }

            } while (userChoice == 0);
            
           
            
        }

        static void addSmartLamp(Smart_Lamp smartlamp)
        {
            
         Console.WriteLine("Enter Device Name.");
         smartlamp.Name = Console.ReadLine();
         
         Console.WriteLine("Enter Device IP Address.");
         smartlamp.IpAddress = Console.ReadLine();
         
         Console.WriteLine("Enter Device Type.");
         smartlamp.Type = Console.ReadLine();
         
         Console.WriteLine("Enter Serial Number.");
         smartlamp.SerialNumber = Console.ReadLine();
         
         Console.WriteLine("Enter your start Color in Hex format.");
         smartlamp.LastColor = Console.ReadLine();
         
         Console.WriteLine("Enter the start Temp for the device.");
         smartlamp.Temp = Convert.ToDouble(Console.ReadLine());
         
         Console.WriteLine("Enter the EEPROM I2C address.");
         smartlamp.EepromAddress = Console.ReadLine();
         
         getLamp(smartlamp);
         
           }

        static void addSmartLock(Smart_Lock smartLock)
        {

            Console.WriteLine("Enter Device Name.");
            smartLock.Name = Console.ReadLine();
         
            Console.WriteLine("Enter Device IP Address.");
            smartLock.IpAddress = Console.ReadLine();
         
            Console.WriteLine("Enter Device Type.");
            smartLock.Type = Console.ReadLine();
         
            Console.WriteLine("Enter Serial Number.");
            smartLock.SerialNumber = Console.ReadLine();
            int selectedTempBattery = 0;
            do
            {
                Console.WriteLine("Does the Smart Lock have a battery? y/n");
                char tempBattery = Convert.ToChar(Console.ReadLine());
                if (tempBattery == 'y')
                {
                    smartLock.HasBattery = true;
                    selectedTempBattery = 1;
                }
                else if (tempBattery == 'n')
                {
                    smartLock.HasBattery = false;
                    selectedTempBattery = 1;
                }
                else
                {
                    Console.WriteLine("Input Invalid. Assuming.");
                    selectedTempBattery = 0;
                }
            } while (selectedTempBattery == 0);


            int selectedTempCamera = 0;

            do
            {

                Console.WriteLine("Does the Smart Lock have a Camera? y/n");
                char tempCamera = Convert.ToChar(Console.ReadLine());
                if (tempCamera == 'y')
                {
                    smartLock.HasCamera = true;
                    selectedTempCamera = 1;
                }else if (tempCamera == 'n')
                {
                    smartLock.HasCamera = false;
                    selectedTempCamera = 1;
                }
                else
                {
                    Console.WriteLine("Input Invalid. Assuming No.");
                    selectedTempCamera = 0;
                }
                
            } while (selectedTempCamera == 0);
            
            
         
            Console.WriteLine("Enter the Type of lock you have.");
            smartLock.LockType = Console.ReadLine();
            
            getLock(smartLock);
            
        }

        static void getLamp(Smart_Lamp smartLamp)
        {
            Console.WriteLine("Smart Lamp Name: " + smartLamp.Name);
            Console.WriteLine("Smart Lamp IP: " + smartLamp.IpAddress);
            Console.WriteLine("Smart Lamp Type: " + smartLamp.Type);
            Console.WriteLine("Smart Lamp Serial Number: " + smartLamp.SerialNumber);
            Console.WriteLine("Smart Lamp Starting Color: " + smartLamp.LastColor);
            Console.WriteLine("Smart Lamp Start Temperature: " + smartLamp.Temp);
            Console.WriteLine("Smart Lamp EEPROM I2C Address: " + smartLamp.EepromAddress);
        }

        static void getLock(Smart_Lock smartLock)
        {
            Console.WriteLine("Smart Lock Device Name: " + smartLock.Name);
            Console.WriteLine("Smart Lock Device IP Address: " + smartLock.IpAddress);
            Console.WriteLine("Smart Lock Device Type: " + smartLock.Type);
            Console.WriteLine("Smart Lock Serial Number: " + smartLock.SerialNumber);
            Console.WriteLine("Smart Lock Battery: " + smartLock.HasBattery);
            Console.WriteLine("Smart Lock Camera: " + smartLock.HasCamera);
            Console.WriteLine("Smart Lock Type: " + smartLock.Type);
        }
    }
}