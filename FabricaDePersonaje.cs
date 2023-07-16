using System.Net;
using EspacioEstoicismo;
namespace FabPersonaje
{
    using pje;
    using System.Text.Json;
    public class FabricaDePersonajes
    {
        public static string[] nombres = { "Tristana", "Caitlyn", "Varus", "Morgana", "Syndra", "Veigar", "Katarina", "Talon", "Renekton", "Mordekaiser" };
        public static string[] apodo = { "Spektro", "Fallen", "Faker", "Mrjuan06", "Asntic", "Aspen", "Gokussj3", "Murrai", "Smith's", "MordeTOP" };

        public List<Personaje> nuevoPersonaje(int cant)
        {
            List<Personaje> listaPersonajes = new List<Personaje>();
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < cant; i++)
            {

                int valor = random.Next(0, 4);
                Personaje nuevo = new Personaje();
                switch (valor)
                {
                    case 0:
                        nuevo = CrearTirador();
                        break;
                    case 1:
                        nuevo = crearMago();
                        break;
                    case 2:
                        nuevo = crearTanque();
                        break;
                    case 3:
                        nuevo = crearLuchador();
                        break;
                }
                listaPersonajes.Add(nuevo);
            }


            return listaPersonajes;

        }


        public static Personaje crearLuchador()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nuevo = new Personaje();
            nuevo.Apodo = apodo[random.Next(0, 10)];
            nuevo.Nombre = nombres[random.Next(0, 10)];
            nuevo.Tp = tipo.luchador;
            nuevo.Salud = 100;
            asignarAtributos(nuevo);
            nuevo.FecNac = establecerFecha();
            nuevo.Edad = calcularEdad(nuevo.FecNac);

            nuevo.OfensiveAttact = new AtaqueOfensivo[2];
            nuevo.OfensiveAttact[0] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[0].NameAtaque = "Grito de Guerra";
            nuevo.OfensiveAttact[0].Habilitado = true;
            nuevo.OfensiveAttact[1] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[1].Habilitado = false;
            if (nuevo.Edad >= 150 && nuevo.Nivel > 5)
            {
                nuevo.OfensiveAttact[1].Habilitado = true;
                nuevo.OfensiveAttact[1].NameAtaque = "Sentencia Devastadora";
            }
            nuevo.DefensiveAttact1 = new AtaqueDefensivo();
            nuevo.DefensiveAttact1.NameDefece = "Aura protectora";
            return nuevo;
        }
        public static Personaje crearTanque()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nuevo = new Personaje();
            nuevo.Apodo = apodo[random.Next(0, 10)];
            nuevo.Nombre = nombres[random.Next(0, 10)];
            nuevo.Tp = tipo.tanque;
            nuevo.Salud = 100;
            asignarAtributos(nuevo);
            nuevo.FecNac = establecerFecha();
            nuevo.Edad = calcularEdad(nuevo.FecNac);

            nuevo.OfensiveAttact = new AtaqueOfensivo[2];
            nuevo.OfensiveAttact[0] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[0].NameAtaque = "Golpe Aplastante";
            nuevo.OfensiveAttact[0].Habilitado = true;
            nuevo.OfensiveAttact[1] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[1].Habilitado = false;
            if (nuevo.Edad >= 150 && nuevo.Nivel > 5)
            {
                nuevo.OfensiveAttact[1].Habilitado = true;
                nuevo.OfensiveAttact[1].NameAtaque = "Carga Audaz";
            }
            nuevo.DefensiveAttact1 = new AtaqueDefensivo();
            nuevo.DefensiveAttact1.NameDefece = "Guardia Creciente";
            return nuevo;

        }
        public static Personaje crearMago()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nuevo = new Personaje();
            nuevo.Apodo = apodo[random.Next(0, 10)];
            nuevo.Nombre = nombres[random.Next(0, 10)];
            nuevo.Tp = tipo.mago;
            nuevo.Salud = 100;
            asignarAtributos(nuevo);
            nuevo.FecNac = establecerFecha();
            nuevo.Edad = calcularEdad(nuevo.FecNac);

            nuevo.OfensiveAttact = new AtaqueOfensivo[2];
            nuevo.OfensiveAttact[0] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[0].NameAtaque = "Rayo de relampago";
            nuevo.OfensiveAttact[0].Habilitado = true;
            nuevo.OfensiveAttact[1] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[1].Habilitado = false;
            if (nuevo.Edad >= 150 && nuevo.Nivel > 5)
            {
                nuevo.OfensiveAttact[1].Habilitado = true;
                nuevo.OfensiveAttact[1].NameAtaque = "Maldicion de Agonia";
            }
            nuevo.DefensiveAttact1 = new AtaqueDefensivo();
            nuevo.DefensiveAttact1.NameDefece = "Escudo de energia";
            return nuevo;
        }
        public static Personaje CrearTirador()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nuevo = new Personaje();
            nuevo.Apodo = apodo[random.Next(0, 10)];
            nuevo.Nombre = nombres[random.Next(0, 10)];
            nuevo.Tp = tipo.tirador;
            nuevo.Salud = 100;
            asignarAtributos(nuevo);
            nuevo.FecNac = establecerFecha();
            nuevo.Edad = calcularEdad(nuevo.FecNac);

            nuevo.OfensiveAttact = new AtaqueOfensivo[2];
            nuevo.OfensiveAttact[0] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[0].NameAtaque = "Fla inmovilizadora";
            nuevo.OfensiveAttact[0].Habilitado = true;
            nuevo.OfensiveAttact[1] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[1].Habilitado = false;
            if (nuevo.Edad >= 150 && nuevo.Nivel > 5)
            {
                nuevo.OfensiveAttact[1].Habilitado = true;
                nuevo.OfensiveAttact[1].NameAtaque = "Bala explosiva";
            }
            nuevo.DefensiveAttact1 = new AtaqueDefensivo();
            nuevo.DefensiveAttact1.NameDefece = "Roll Esquivadizo";




            /* Random random = new Random();
            var nuevo = new Personaje();
            nuevo.Apodo = apodo[random.Next(0, 10)];
            nuevo.Nombre = nombres[random.Next(0, 10)];
            nuevo.Tp = tipo.tirador;
            nuevo.Salud = 100;
            nuevo.Fuerza = random.Next(5, 11);
            nuevo.Velocidad = random.Next(5, 11);
            nuevo.Armadura = random.Next(3, 10);
            nuevo.FecNac = establecerFecha();
            nuevo.Edad = calcularEdad(nuevo.FecNac);


            if (nuevo.Edad <= 150)
            {
                nuevo.Destreza = random.Next(3, 6);
                nuevo.Nivel = random.Next(1, 11);
            }
            else
            {
                nuevo.Destreza = random.Next(0, 4);
                nuevo.Nivel = random.Next(6, 11);
            }
            nuevo.OfensiveAttact = new AtaqueOfensivo[2];
            nuevo.OfensiveAttact[0] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[0].NameAtaque = "Fla inmovilizadora";
            nuevo.OfensiveAttact[0].Habilitado = true;
            nuevo.OfensiveAttact[1] = new AtaqueOfensivo();
            nuevo.OfensiveAttact[1].Habilitado = false;
            if (nuevo.Nivel >= 5)
            {
                nuevo.OfensiveAttact[1].Habilitado = true;
                nuevo.OfensiveAttact[1].NameAtaque = "Bala explosiva";
            }
            nuevo.DefensiveAttact1 = new AtaqueDefensivo();
            nuevo.DefensiveAttact1.NameDefece = "Roll Esquivadizo";
 */

            return nuevo;
        }

        public static void asignarAtributos(Personaje nuevo)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            nuevo.Defensa = false;
            switch (nuevo.Tp)
            {
                case tipo.tirador:
                    nuevo.Fuerza = random.Next(5, 9);
                    nuevo.Velocidad = random.Next(6, 10);
                    nuevo.Armadura = random.Next(3, 7);
                    nuevo.Destreza = random.Next(4, 8);
                    break;

                case tipo.mago:
                    nuevo.Fuerza = random.Next(4, 8);
                    nuevo.Velocidad = random.Next(5, 9);
                    nuevo.Armadura = random.Next(3, 7);
                    nuevo.Destreza = random.Next(5, 9);
                    break;

                case tipo.tanque:
                    nuevo.Fuerza = random.Next(6, 10);
                    nuevo.Velocidad = random.Next(4, 8);
                    nuevo.Armadura = random.Next(6, 10);
                    nuevo.Destreza = random.Next(3, 7);
                    break;

                case tipo.luchador:
                    nuevo.Fuerza = random.Next(7, 11);
                    nuevo.Velocidad = random.Next(5, 9);
                    nuevo.Armadura = random.Next(5, 9);
                    nuevo.Destreza = random.Next(4, 8);
                    break;
            }
            nuevo.Nivel = random.Next(1, 11);
        }
        public static DateTime establecerFecha()
        {
            //PONER FECHA  
            Random random = new Random();
            DateTime ahora = DateTime.Now;
            int yearAleatorio = random.Next(ahora.Year - 50, ahora.Year);
            int monthAleatorio = random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(yearAleatorio, monthAleatorio);
            int dayAleatorio = random.Next(1, daysInMonth + 1);
            DateTime fechaAleatoria = new DateTime(yearAleatorio, monthAleatorio, dayAleatorio);
            return fechaAleatoria;

        }
        public static int calcularEdad(DateTime fecNac)
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - fecNac.Year;
            if (ahora.Month < fecNac.Month || (ahora.Month == fecNac.Month && ahora.Day < fecNac.Day))
            {
                edad--;
            }
            return edad;


        }
    }

    public class personajeJSON
    {
        public void guardarPersonajes(List<Personaje> lista, string fileName)
        {

            string json = JsonSerializer.Serialize(lista);

            File.WriteAllText(fileName, json);
        }
        // Deserializar un archivo JSON
        public List<Personaje>? leerPersonajes(string fileName)
        {
            if (File.Exists(fileName))
            {

                String jsonString = File.ReadAllText(fileName);
                List<Personaje>? personajesDeserializados = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
                return personajesDeserializados;

            }
            else
            {
                System.Console.WriteLine("El archivo de nombre: " + fileName + " no existe");
                return null;
            }
        }
        public bool existe(string? fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mostrarPersonajes(List<Personaje> lista)
        {
            foreach (var personaje in lista)
            {
                string nombreYApodo = "Nombre: " + personaje.Nombre + "            Apodo: " + personaje.Apodo;
                string aux2 = "Fecha: " + personaje.FecNac.ToString("dd/MM/yyyy") + "       Edad: " + personaje.Edad;
                string aux3 = "Tipo: " + personaje.Tp + "      Vel: " + personaje.Velocidad + "     Destreza: " + personaje.Destreza + "     Fuerza: " + personaje.Fuerza;
                string aux4 = "Nivel: " + personaje.Nivel + "     Armadura: " + personaje.Armadura + "      Salud: " + personaje.Salud;
                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                System.Console.WriteLine("~~~" + AsciiFabrica.Centrar(nombreYApodo, 70) + "~~~");
                System.Console.WriteLine("~~~" + AsciiFabrica.Centrar(aux2, 70) + "~~~");
                System.Console.WriteLine("~~~" + AsciiFabrica.Centrar(aux3, 70) + "~~~");
                System.Console.WriteLine("~~~" + AsciiFabrica.Centrar(aux4, 70) + "~~~");
                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public void nuevaPartida(string directory)
        {
            string fileName = "personajes.json";
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("~~~~" + AsciiFabrica.Centrar("Bienvendios", 70) + "~~~");
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("~~ Desea crear una nueva lista de personajes o jugar con la ya existente? ~~");
            System.Console.WriteLine("~~~" + AsciiFabrica.Centrar("(1: Nueva Partida | 2: Existente)", 70) + "~~~");
            string resp = System.Console.ReadLine();
            if (resp == "1")
            {
                string[] filesToDelete = Directory.GetFiles(directory, fileName);
                foreach (var item in filesToDelete)
                {

                    File.Delete(item);
                }
            }
        }

    }

    public static class calculos
    {

        public static void recibirDanio(Personaje defensor, double danio)
        {
            defensor.Salud -= danio;

        }

        public static double calcularDanio(Personaje atacante)
        {


            var seed = Environment.TickCount;
            var random = new Random(seed);
            int valormax = 0;
            if (atacante.Nivel >= 5)
            {
                valormax = 3;
            }
            else
            {
                valormax = 2;
            }
            // Elijo ataque
            int num = random.Next(0, valormax);
            double danioProvocado;

            if (num == 1) // ataque predefinido
            {
                atacante.Defensa = false;
                double ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
                int efectividad = random.Next(1, 101);
                double defensa = atacante.Armadura * atacante.Velocidad;
                int constanteAjuste = 500;
                danioProvocado = (ataque * efectividad - defensa) / constanteAjuste;
                /*  var NombreAtaque = atacante.OfensiveAttact[0].NameAtaque;
                 System.Console.WriteLine("Aplico '{0}' provocando '{1}' de danio", NombreAtaque, danioProvocado); */
            }
            else if (num == 2) // Ataque nivel pro ( efectividad 100%)
            {
                atacante.Defensa = false;
                double ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
                int efectividad = 95;
                double defensa = atacante.Armadura * atacante.Velocidad;
                int constanteAjuste = 500;
                danioProvocado = (ataque * efectividad - defensa) / constanteAjuste;
                /*      var NombreAtaque = atacante.OfensiveAttact[1].NameAtaque;
                     System.Console.WriteLine("Aplico '{0}' provocando '{1}' de danio", NombreAtaque, danioProvocado); */
            }
            else
            {
                atacante.Defensa = true;
                danioProvocado = 0;
                /* System.Console.WriteLine("Esquivo el golpe con  " +  atacante.DefensiveAttact1.NameDefece); */
            }
            return danioProvocado;
        }
        public static Personaje combate(Personaje jugador1, Personaje jugador2)
        {
            if (jugador1.Salud <= 0 || jugador2.Salud <= 0)
            {
                if (jugador1.Salud <= 0)
                {
                    jugador2.Salud = 100;
                    return jugador2;
                }
                else
                {
                    jugador1.Salud = 100;
                    return jugador1;
                }
            }
            else
            {

                if (jugador2.Defensa == false)
                {
                    double danioJub1 = calcularDanio(jugador1);
                    recibirDanio(jugador2, danioJub1);
                }
                if (jugador1.Defensa == false)
                {
                    double danioJub2 = calcularDanio(jugador2);
                    recibirDanio(jugador1, danioJub2);
                }

                return combate(jugador1, jugador2);
            }
        }

        public static Personaje combatePorRondas(List<Personaje> listaPersonajes)
        {
            System.Console.WriteLine(listaPersonajes.Count);
            if ((listaPersonajes.Count % 2) != 0)
            {
                listaPersonajes.RemoveAt(listaPersonajes.Count - 1);
            }
            int ronda = 1;
            while (listaPersonajes.Count != 1)
            {
                System.Console.WriteLine("Ronda n: " + ronda);
                List<Personaje> ganadoresRonda = new List<Personaje>();
                for (int i = 0; i < listaPersonajes.Count; i += 2)
                {
                    Personaje luchador1 = listaPersonajes[i];
                    Personaje luchador2 = listaPersonajes[i + 1];

                    Personaje ganador = combate(luchador1, luchador2);
                    System.Console.WriteLine("El ganador es: " + ganador.Apodo);
                    ganadoresRonda.Add(ganador);
                }

                listaPersonajes = ganadoresRonda;
                ronda++;
            }
            return listaPersonajes[0];
        }
        /* public static class manejoDeArchivos
        {
            public static void registrarCombate(string directory)
            {
                if (!Directory.Exists(directory))
                {
                    string? rutaCSV = Path.Combine(directory, "registroCombate.csv");

                    using (StreamWriter stw = new StreamWriter(rutaCSV))
                    {
                        stw.WriteLine("Ronda n:  ")
                    }

                }
            }
        } */
    }
    public static class AsciiFabrica
    {
        public static string Centrar(string palabra, int espacios)
        {
            int Blanco = (espacios - palabra.Length) / 2;
            string palabraCentrada = palabra.PadLeft(palabra.Length + Blanco);
            palabraCentrada = palabraCentrada.PadRight(espacios);
            return palabraCentrada;
        }
    }

    /*    public static class consultaApi
       {
           private static void GetQuote()
           {
               var url = $"https://api.themotivate365.com/stoic-quote";
               var request = (HttpWebRequest)WebRequest.Create(url);
               request.Method = "GET";
               request.ContentType = "application/json";
               request.Accept = "application/json";
               try
               {
                   using (WebResponse response = request.GetResponse())
                   {
                       using (Stream strReader = response.GetResponseStream())
                       {
                           if (strReader == null) return;
                           using (StreamReader objReader = new StreamReader(strReader))
                           {
                               string responseBody = objReader.ReadToEnd();
                               Frase Quote = JsonSerializer.Deserialize<Frase>(responseBody);
                               System.Console.WriteLine( "~~~" + AsciiFabrica.Centrar(Quote.quote, 70) + "~~~");


                           }
                       }
                   }
               }
               catch (WebException ex)
               {
                   Console.WriteLine("Problemas de acceso a la API");
               }
           }
       }
    */

}

