using T3_Pr1_Hugo;

public class MyProgram
{
    const string Menu = "1.-Iniciar simulació\n2.-Veure informe\n3.-Sortir";
    const string ErrorMsg = "error, numero invalid";
    const string InputMsg = "insereix valor:";
    const string SiumlationsNMsg = "Cuantes simulacions vols fer?";
    const string ChooseSimsMsg = "Escull un sistema energetic a simular:\n1.-Eolic\n2.-Hidroelectric\n3.-Solar";

    private static ASistemaEnergia[] simulations;

    public static void Main()
    {
        int menuSelecter = 0;

        do
        {
            
            Console.WriteLine(Menu);

            
            menuSelecter = MenuLogic();

        } while (menuSelecter != 3); 

        Console.WriteLine("El programa ha finalitzat.");
    }

    public static int MenuLogic()
    {
        int menuSelecter = 0;
        bool valid = false;
        do
        {
            try
            {
                menuSelecter = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
            }
            valid = menuSelecter >= 1 && menuSelecter <= 3;
            if (!valid) Console.WriteLine(ErrorMsg);

        } while (!valid);

        
        switch (menuSelecter)
        {
            case 1:
                StartSimulation();
                break;
            case 2:
                Visualize(simulations);
                break;
            case 3:
                Console.WriteLine("Sortint del programa...");
                break;
        }

        return menuSelecter;
    }

    public static void Visualize(ASistemaEnergia[] simulations)
    {
        if (simulations == null || simulations.Length == 0)
        {
            Console.WriteLine("No hi ha simulacions disponibles.");

        }
        else
        {
            Console.WriteLine($"{"Tipus Sistema",-20} {"Data Creació",-20} {"Energia Calculada",-20}");
            Console.WriteLine(new string('-', 60)); 

            
            foreach (var sistem in simulations)
            {
                Console.WriteLine(sistem.ToString());
            }
            Console.WriteLine(new string('-', 60)); 

        }

    }

    public static void StartSimulation()
    {
        Console.WriteLine(SiumlationsNMsg);
        int numSims = int.Parse(Console.ReadLine());

        simulations = new ASistemaEnergia[numSims];

        for (int i = 0; i < numSims; i++)
        {
            simulations[i] = ChooseSimulation();
            Console.Clear();
        }
    }

    public static ASistemaEnergia ChooseSimulation()
    {
        Console.WriteLine(ChooseSimsMsg);
        int simSelector = int.Parse(Console.ReadLine());

        switch (simSelector)
        {
            case 1:
                return new SistemaEolic();
            case 2:
                return new SistemaHidroelectric();
            case 3:
                return new SistemaSolar();
            default:
                Console.WriteLine("Selecció no vàlida. Es selecciona el sistema eòlic per defecte.");
                return new SistemaEolic();
        }
    }
}