using System;

namespace OOP_Example_Console
{
    public class Device
    {
        private string name;
        private string ipAddress;
        private string type;
        private string serialNumber;

        public Device(string name, string ipAddress, string type, string serialNumber)
        {
            this.name = name;
            this.ipAddress = ipAddress;
            this.type = type;
            this.serialNumber = serialNumber;
        }

        public Device()
        {
            
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string IpAddress
        {
            get => ipAddress;
            set => ipAddress = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string SerialNumber
        {
            get => serialNumber;
            set => serialNumber = value;
        }
    }
}