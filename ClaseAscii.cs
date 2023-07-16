namespace EspacioFabPalabras
{
    public static class AsciiFabrica
    {
        public static string Centrar(string palabra, int espacios)
        {
            int Blanco = (espacios - palabra.Length) / 2;
            string palabraCentrada = palabra.PadLeft(palabra.Length + Blanco);
            palabraCentrada = palabraCentrada.PadRight(espacios);
            return palabraCentrada;
        }

        public static void bienvenida()
        {
            string aux = @"
▀█████████▄   ▄█     ▄████████ ███▄▄▄▄    ▄█    █▄     ▄████████ ███▄▄▄▄    ▄█  ████████▄   ▄██████▄     ▄████████ 
  ███    ███ ███    ███    ███ ███▀▀▀██▄ ███    ███   ███    ███ ███▀▀▀██▄ ███  ███   ▀███ ███    ███   ███    ███ 
  ███    ███ ███▌   ███    █▀  ███   ███ ███    ███   ███    █▀  ███   ███ ███▌ ███    ███ ███    ███   ███    █▀  
 ▄███▄▄▄██▀  ███▌  ▄███▄▄▄     ███   ███ ███    ███  ▄███▄▄▄     ███   ███ ███▌ ███    ███ ███    ███   ███        
▀▀███▀▀▀██▄  ███▌ ▀▀███▀▀▀     ███   ███ ███    ███ ▀▀███▀▀▀     ███   ███ ███▌ ███    ███ ███    ███ ▀███████████ 
  ███    ██▄ ███    ███    █▄  ███   ███ ███    ███   ███    █▄  ███   ███ ███  ███    ███ ███    ███          ███ 
  ███    ███ ███    ███    ███ ███   ███ ███    ███   ███    ███ ███   ███ ███  ███   ▄███ ███    ███    ▄█    ███ 
▄█████████▀  █▀     ██████████  ▀█   █▀   ▀██████▀    ██████████  ▀█   █▀  █▀   ████████▀   ▀██████▀   ▄████████▀  
                                                                                                                   
";

            string aux2 = "Bienvenidos";
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("~~~" + Centrar(aux2, 40) + "~~~");
        }
    }
}


