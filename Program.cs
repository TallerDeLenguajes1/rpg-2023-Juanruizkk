// See https://aka.ms/new-console-template for more information
using FabPersonaje;
using pje;
using System.Text.Json;
List<Personaje> listaPersonajes = new List<Personaje>();
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


    var fabPersonaje = new FabricaDePersonajes();

    listaPersonajes = fabPersonaje.nuevoPersonaje(2);
    jsonPlayers.guardarPersonajes(listaPersonajes, fileName);
    jsonPlayers.mostrarPersonajes(listaPersonajes);


}


