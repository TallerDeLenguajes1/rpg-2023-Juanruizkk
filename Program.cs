// See https://aka.ms/new-console-template for more information
using FabPersonaje;
using personaje;
using System.Text.Json;
List<Personaje> listaPersonajes = new List<Personaje>();
string[] nombres = { "Tristana", "Caitlyn", "Varus", "Morgana", "Syndra", "Veigar", "Katarina", "Talon", "Renekton", "Mordekaiser" };
string[] apodo = { "Spektro", "Fallen", "Faker", "Mrjuan06", "Asntic", "Aspen", "Gokussj3", "Murrai", "Smith's", "MordeTOP" };

string fileName = "personajes.json";
var jsonPlayers = new personajeJSON(); // Creo instancia clase personajeJSON

if (jsonPlayers.existe(fileName))
{
    List<Personaje>? PersonajeDeserialiados = jsonPlayers.leerPersonajes(fileName);

    if (PersonajeDeserialiados != null)
    {
        jsonPlayers.mostrarPersonajes(PersonajeDeserialiados);
    }
}
else
{

    Personaje newPlayer = new Personaje();
    var fabPersonaje = new FabricaDePersonajes();
    for (int i = 0; i < 10; i++)
    {
        if (i < 3)
        {
            newPlayer = fabPersonaje.nuevoPersonaje(nombres[i], tipo.tirador, apodo[i]);
        }
        else if (i < 6)
        {
            newPlayer = fabPersonaje.nuevoPersonaje(nombres[i], tipo.mago, apodo[i]);
        }
        else if (i < 8)
        {
            newPlayer = fabPersonaje.nuevoPersonaje(nombres[i], tipo.luchador, apodo[i]);
        }
        else
        {
            newPlayer = fabPersonaje.nuevoPersonaje(nombres[i], tipo.tanque, apodo[i]);
        }
        listaPersonajes.Add(newPlayer);
    }
    jsonPlayers.guardarPersonajes(listaPersonajes, fileName);
    jsonPlayers.mostrarPersonajes(listaPersonajes);
}


