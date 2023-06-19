namespace FabPersonaje
{
    using personaje;
    using System.Text.Json;

    public class FabricaDePersonajes
    {

        public Personaje nuevoPersonaje(string? nombre, tipo tp, string? apodo)
        {
            Random random = new Random();
            var nuevo = new Personaje();
            nuevo.Apodo = apodo;
            nuevo.Nombre = nombre;
            nuevo.Tp = tp;

            if (nuevo.Tp == tipo.tirador)
            {
                nuevo.Fuerza = random.Next(5, 11);
                nuevo.Velocidad = random.Next(5, 11);
                nuevo.Armadura = random.Next(3, 10);
                nuevo.Edad = random.Next(0, 300);

                if (nuevo.Edad <= 150)
                {
                    nuevo.Destreza = random.Next(3, 6);
                    nuevo.Salud = random.Next(70, 101);
                    nuevo.Nivel = random.Next(1, 11);
                }
                else
                {
                    nuevo.Destreza = random.Next(0, 4);
                    nuevo.Salud = random.Next(40, 71);
                    nuevo.Nivel = random.Next(6, 11);
                }
            }

            if (nuevo.Tp == tipo.mago)
            {
                nuevo.Fuerza = random.Next(3, 11);
                nuevo.Velocidad = random.Next(2, 11);
                nuevo.Armadura = random.Next(3, 10);
                nuevo.Edad = random.Next(0, 300);

                if (nuevo.Edad <= 100)
                {
                    nuevo.Destreza = random.Next(0, 5);
                    nuevo.Salud = random.Next(70, 101);
                    nuevo.Nivel = random.Next(1, 11);
                }
                else if (nuevo.Edad > 100 || nuevo.Edad < 200)
                {
                    nuevo.Destreza = random.Next(0, 4);
                    nuevo.Salud = random.Next(65, 91);
                    nuevo.Nivel = random.Next(6, 11);
                }
                else
                {
                    nuevo.Destreza = random.Next(0, 3);
                    nuevo.Salud = random.Next(40, 91);
                    nuevo.Nivel = random.Next(8, 11);
                }
            }
            if (nuevo.Tp == tipo.tanque)
            {
                nuevo.Fuerza = random.Next(7, 11);
                nuevo.Velocidad = random.Next(2, 5);
                nuevo.Armadura = random.Next(7, 10);
                nuevo.Edad = random.Next(0, 300);
                nuevo.Destreza = random.Next(0, 4);
                if (nuevo.Edad <= 150)
                {
                    nuevo.Salud = random.Next(40, 86);
                    nuevo.Nivel = random.Next(1, 11);
                }
                else
                {
                    nuevo.Salud = random.Next(30, 76);
                    nuevo.Nivel = random.Next(6, 11);
                }
            }

            if (nuevo.Tp == tipo.luchador)
            {
                nuevo.Fuerza = random.Next(3, 8);
                nuevo.Velocidad = random.Next(2, 7);
                nuevo.Armadura = random.Next(2, 8);
                nuevo.Edad = random.Next(0, 300);
                nuevo.Destreza = random.Next(0, 5);
                if (nuevo.Edad < 100)
                {
                    nuevo.Salud = random.Next(60, 90);
                    nuevo.Nivel = random.Next(1, 11);
                }
                else
                {
                    nuevo.Salud = random.Next(40, 70);
                    nuevo.Nivel = random.Next(7, 11);
                }
            }

            return nuevo;
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
                System.Console.WriteLine("Jugador de nombre: " + personaje.Nombre + ", tambien conocido como: " + personaje.Apodo);
                System.Console.WriteLine("VEL.: " + personaje.Velocidad + " Destreza: " + personaje.Destreza + " Fuerza: " + personaje.Fuerza);
                System.Console.WriteLine("Nivel: " + personaje.Nivel + " Armadura: " + personaje.Armadura + " Salud: " + personaje.Salud);

            }
        }
    }
}
