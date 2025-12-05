namespace MachineManagement
{
    public class SearchMachineClass
    {
        public static void SearchMachineFunc()
        {
            string tiemkiemID = "";
            while (true)
            {
                Console.Write("Nhap ID cua thiet bi can tim: ");
                string? checkIDInput = Console.ReadLine();
                if (string.IsNullOrEmpty(checkIDInput))
                {
                    Console.WriteLine("Ban chua nhap ID thiet bi");
                    continue;
                }
                else
                {
                    tiemkiemID = checkIDInput;
                }
                break;
            }
            DataListClass.TiemkiemThietBi(tiemkiemID);
        }
    }
}
