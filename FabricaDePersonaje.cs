using System.Net;
using EspacioEstoicismo;
using System.Collections;
using keyboardMenu;
using pje;
using System.Text.Json;

namespace FabPersonaje
{
    public class FabricaDePersonajes
    {
        public static List<string> nombres = new List<string> { "Tristana", "Caitlyn", "Varus", "Morgana", "Syndra", "Veigar", "Katarina", "Talon", "Renekton", "Mordekaiser" };
        public static List<string> apodo = new List<string> { "Spektro", "Fallen", "Faker", "Mrjuan06", "Asntic", "Aspen", "Gokussj3", "Murrai", "Smith's", "MordeTOP" };

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
                Thread.Sleep(100);
                listaPersonajes.Add(nuevo);
            }


            return listaPersonajes;

        }


        public static Personaje crearLuchador()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nuevo = new Personaje();
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
            return nuevo;
        }

        public static void asignarAtributos(Personaje nuevo)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int indice = random.Next(0, nombres.Count - 1);
            List<string> nombresaux = nombres;
            List<string> apodosaux = apodo;
            nuevo.Nombre = nombresaux[indice];
            nuevo.Apodo = apodosaux[indice];
            nombresaux.RemoveAt(indice);
            apodosaux.RemoveAt(indice);
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
            List<Personaje> listaAux = lista;
            foreach (var personaje in listaAux)
            {

                string nombreYApodo = "Nombre: " + personaje.Nombre + "            Apodo: " + personaje.Apodo;
                string aux2 = "Fecha: " + personaje.FecNac.ToString("dd/MM/yyyy") + "       Edad: " + personaje.Edad;
                string aux3 = "Tipo: " + personaje.Tp + "      Vel: " + personaje.Velocidad + "     Destreza: " + personaje.Destreza + "     Fuerza: " + personaje.Fuerza;
                string aux4 = "Nivel: " + personaje.Nivel + "     Armadura: " + personaje.Armadura + "      Salud: " + personaje.Salud;
                System.Console.WriteLine("────────────────────────────────────────────────────────────────────────────");
                System.Console.WriteLine("───" + AsciiFabrica.Centrar(nombreYApodo, 70) + "───");
                System.Console.WriteLine("───" + AsciiFabrica.Centrar(aux2, 70) + "───");
                System.Console.WriteLine("───" + AsciiFabrica.Centrar(aux3, 70) + "───");
                System.Console.WriteLine("───" + AsciiFabrica.Centrar(aux4, 70) + "───");
                System.Console.WriteLine("────────────────────────────────────────────────────────────────────────────");
            }
            System.Console.WriteLine("Presione una tecla para seguir");
            System.Console.ReadKey(true);
            System.Console.WriteLine("────────────────────────────────────────────────────────────────────────────");

        }

        public static string directory = Directory.GetCurrentDirectory();
        public void nuevaPartida(string directory)
        {

            var jsonPlayers = new personajeJSON();
            string fileName = "personajes.json";
            string prompt = "Desea crear una nueva lista de personajes o jugar con la lista de la partida anterior?";
            string[] options = { "Nueva Lista Personajes", "Jugar con lista anterior", "salir" };
            Menu secondMenu = new Menu(prompt, options);
            int resp = secondMenu.Run();
            switch (resp)
            {
                case 0:
                    string[] filesToDelete = Directory.GetFiles(directory, fileName);
                    foreach (var item in filesToDelete)
                    {

                        File.Delete(item);
                    }
                    string secondPrompt = "Cuantos Atacantes quiere generar?";
                    string[] secondOptions = { "2", "4", "8", "12" };
                    Menu thirdMenu = new Menu(secondPrompt, secondOptions);
                    int aux = thirdMenu.Run();
                    switch (aux)
                    {
                        case 0:
                            List<Personaje> nuevaLista = generarNuevaLista(2);
                            cuartoMenu(nuevaLista);
                            // menu final
                            break;
                        case 1:
                            List<Personaje> lista4per = generarNuevaLista(4);
                            cuartoMenu(lista4per);

                            break;
                        case 2:
                            List<Personaje> lista6per = generarNuevaLista(8);
                            cuartoMenu(lista6per);
                            break;
                        case 3:
                            List<Personaje> lista8per = generarNuevaLista(12);
                            cuartoMenu(lista8per);
                            break;


                    }
                    break;
                case 1:
                    // Cuarto menu donde pelean o muestro los jugadores
                    List<Personaje>? PersonajeDeserialiados = jsonPlayers.leerPersonajes(fileName);
                    cuartoMenu(PersonajeDeserialiados);

                    break;
                case 2:
                    secondMenu.ExitGame();
                    break;
            }

        }

        public void cuartoMenu(List<Personaje> listaPersonajes)
        {
            Menu fourthMenu;
            int valor;

            int band = 0;

            do
            {
                string fourthPrompt = "Listo para jugar?";
                string[] fourthOptions = { "Combate", "Mostrar Luchadores", "Salir" };
                fourthMenu = new Menu(fourthPrompt, fourthOptions);
                valor = fourthMenu.Run();

                switch (valor)
                {
                    case 0:
                        Personaje ganador = calculos.combatePorRondas(listaPersonajes);
                        System.Console.WriteLine("Presione una tecla para seguir");
                        System.Console.ReadKey(true);
                        band++;

                        break;
                    case 1:
                        mostrarPersonajes(listaPersonajes);
                        break;
                    case 2:
                        fourthMenu.ExitGame();
                        break;
                }
            } while (valor != 2 && band == 0);

            string fivePrompt = "Desea Volver a Jugar";
            string[] fiveOptions = { "Volver al Jugar", "Salir" };
            var fiveMenu = new Menu(fivePrompt, fiveOptions);
            valor = fiveMenu.Run();

            switch (valor)
            {
                case 0:
                    var nuevapart = new personajeJSON();
                    nuevapart.nuevaPartida(directory);
                    break;
                case 1:
                    fiveMenu.ExitGame();
                    break;
            }

        }

        public List<Personaje> generarNuevaLista(int cant)
        {
            var jsonPlayers = new personajeJSON();
            List<Personaje> listaPersonajes = new List<Personaje>();
            var fabPersonaje = new FabricaDePersonajes();

            listaPersonajes = fabPersonaje.nuevoPersonaje(cant);
            jsonPlayers.guardarPersonajes(listaPersonajes, "personajes.json");
            return listaPersonajes;
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
            if ((listaPersonajes.Count % 2) != 0)
            {
                listaPersonajes.RemoveAt(listaPersonajes.Count - 1);
            }
            int ronda = 1;
            while (listaPersonajes.Count != 1)
            {
                string aux = "Ronda n: " + ronda;
                System.Console.WriteLine("───" + AsciiFabrica.Centrar(aux, 70) + "───");
                List<Personaje> ganadoresRonda = new List<Personaje>();
                for (int i = 0; i < listaPersonajes.Count; i += 2)
                {
                    Personaje luchador1 = listaPersonajes[i];
                    Personaje luchador2 = listaPersonajes[i + 1];
                    System.Console.WriteLine("───" + AsciiFabrica.Centrar(luchador1.Apodo + "  Vs  " + luchador2.Apodo, 70) + "───");

                    Personaje ganador = combate(luchador1, luchador2);
                    System.Console.WriteLine("───" + AsciiFabrica.Centrar("El ganador es: " + ganador.Apodo, 60) + "───");
                    ganadoresRonda.Add(ganador);
                    System.Console.WriteLine("───" + AsciiFabrica.Centrar(ganador.Apodo + ": " + consultaApi.GetQuote(), 60) + "───");
                }

                listaPersonajes = ganadoresRonda;
                ronda++;
            }
            return listaPersonajes[0];
        }

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

    public static class consultaApi
    {
        /*  public static void guardarFrase(Frase cita, string fileName)
         {

             string? jsonString = JsonSerializer.Serialize(cita);

             File.WriteAllText(fileName, jsonString);
         }
         // Deserializar un archivo JSON
         public static Frase? leerFrase(string fileName)
         {
             if (File.Exists(fileName))
             {

                 String jsonString = File.ReadAllText(fileName);
                 Frase? cita = JsonSerializer.Deserialize<Frase>(jsonString);
                 return cita;

             }
             else
             {
                 System.Console.WriteLine("El archivo de nombre: " + fileName + " no existe");
                 return null;
             }
         } */
        public static string? GetQuote()
        {
            var url = $"https://api.themotivate365.com/stoic-quote";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "*/*";
            request.Accept = "*/*";
            string? cita = "";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader strReader = new StreamReader(response.GetResponseStream()))
                    {
                        var responseBody = strReader.ReadToEnd();
                        Frase Phrase = JsonSerializer.Deserialize<Frase>(responseBody);
                        cita = Phrase.quote;
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
            return cita;
        }
    }


}

