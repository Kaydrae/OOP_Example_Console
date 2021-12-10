using System;

namespace OOP_Example_Console
{
    public class Smart_Lock : Device
    {
        private bool hasCamera;
        private bool hasBattery;
        private string lockType;

        public Smart_Lock(string name, string ipAddress, string type, string serialNumber, bool hasCamera, bool hasBattery, string lockType) : base(name, ipAddress, type, serialNumber)
        {
            this.hasCamera = hasCamera;
            this.hasBattery = hasBattery;
            this.lockType = lockType;
        }

        public Smart_Lock()
        {
            
        }
        public bool HasBattery
        {
            get => hasBattery;
            set => hasBattery = value;
        }

        public bool HasCamera
        {
            get => hasCamera;
            set => hasCamera = value;
        }

        public string LockType
        {
            get => lockType;
            set => lockType = value;
        }
    }
}