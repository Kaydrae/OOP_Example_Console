using System;

namespace OOP_Example_Console
{
    public class Smart_Lamp : Device
    {
        private string lastColor;
        private double temp;
        private string eepromAddress;


        public Smart_Lamp(string name, string ipAddress, string type, string serialNumber, string lastColor, float temp, string eepromAddress) : base(name, ipAddress, type, serialNumber)
        {
            this.lastColor = lastColor;
            this.temp = temp;
            this.eepromAddress = eepromAddress;
        }

        public Smart_Lamp()
        {
            
        }

        public string LastColor
        {
            get => lastColor;
            set => lastColor = value;
        }

        public double Temp
        {
            get => temp;
            set => temp = value;
        }

        public string EepromAddress
        {
            get => eepromAddress;
            set => eepromAddress = value;
        }
    }
}