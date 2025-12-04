namespace MachineManagement
{
    public class ExitfunctionClass
    {
        public static void ExitMethod()
        {
            bool exitFunc = false;
            while (true)
            {
                Console.Write("\nBack to main menu, press number 0: ");
                string? input = Console.ReadLine();

                // Validate numeric input
                if (!int.TryParse(input, out int exitNum))
                {
                    Console.WriteLine("\nInvalid input. Please enter the number 0.");
                    continue;
                }
                if (exitNum == 0)
                {
                    exitFunc = true;
                    Console.Clear();
                    break; 
                }
                else
                {
                    Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                }
            }
        }
    }
}
