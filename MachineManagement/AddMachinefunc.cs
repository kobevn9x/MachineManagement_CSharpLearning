namespace MachineManagement
{
    public class AddMachinefunc
    {
        public static void AddMchine()
        {
            List<Machines> Thietbi = new List<Machines>();
            while (true)
            {
                Console.Clear();
                MainMenu.PrintMenu();
                Console.WriteLine("---Menu: Them thiet bi moi---\n");
                Machines newMachine = new();
                Console.Write("Nhap ma Thiet Bi: ");
                newMachine.MachineID = Console.ReadLine();

                Console.Write("Nhap ten Thiet Bi: ");
                newMachine.MachineName = Console.ReadLine();
                Console.Write("Nhap kieu Thiet Bi: ");
                newMachine.MachineType = Console.ReadLine();
                Console.Write("Nhap nm san xuat: ");
                newMachine.YearOfMachineManufacturers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Hang san xuat: ");
                newMachine.MachineManufacturers = Console.ReadLine();
                Console.Write("Trang thai hien tai cua may: ");
                newMachine.MachineStatus = Console.ReadLine();

                Thietbi.Add(newMachine);
                Console.WriteLine("Them moi thiet bi thanh cong!");
                Console.WriteLine("Bam 'Y' de them tiep, Bam 'F' de hoan tat");
                
                string userInput = Console.ReadLine().ToUpper();
                if (userInput != "Y")
                {
                    break;
                }
            }
            Console.WriteLine($"Da nhap duoc {Thietbi.Count}"+" may vao DB");
        }
    }
}
