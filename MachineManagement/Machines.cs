namespace MachineManagement
{
    public class Machines
    {
        public string? MachineID                     { get; set; }
        public string? MachineName                   { get; set; }
        public string? MachineType                   { get; set; }
        public string? MachineManufacturers          { get; set; }
        public int    YearOfMachineManufacturers     { get; set; }
        public string? MachineStatus                 { get; set; }

        public void AddMachine(string machineID,            string machineName,   string machineType,
                               string machineManufacturers, string machineStatus, int yearOfMachineManufacturers)
        {
            MachineID = machineID;
            MachineName = machineName;
            MachineType = machineType;
            MachineManufacturers = machineManufacturers;
            MachineStatus = machineStatus;
            YearOfMachineManufacturers = yearOfMachineManufacturers;
        }
    }
}
