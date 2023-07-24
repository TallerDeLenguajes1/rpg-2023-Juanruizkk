// See https://aka.ms/new-console-template for more information
using FabPersonaje;
using pje;
using System.Collections.Generic;
using System.IO;
using keyboardMenu;


string directory = Directory.GetCurrentDirectory();

List<Personaje> listaPersonajes = new List<Personaje>();
string fileName = "personajes.json";
var jsonPlayers = new personajeJSON(); // Creo instancia clase personajeJSON
/* 
string prompt = "Bienvenidos al juego";
string[] options = { "Jugar" }; */
Menu mainMenu = new Menu();
mainMenu.runMainMenu();



jsonPlayers.nuevaPartida(directory);



/* if (jsonPlayers.existe(fileName))
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

    listaPersonajes = fabPersonaje.nuevoPersonaje(8);
    jsonPlayers.guardarPersonajes(listaPersonajes, fileName);
    jsonPlayers.mostrarPersonajes(listaPersonajes);

    Personaje ganador = calculos.combatePorRondas(listaPersonajes);

    System.Console.WriteLine(@"
       _                               _                            
   ___| |   __ _  __ _ _ __   __ _  __| | ___  _ __    ___  ___   _ 
  / _ \ |  / _` |/ _` | '_ \ / _` |/ _` |/ _ \| '__|  / _ \/ __| (_)
 |  __/ | | (_| | (_| | | | | (_| | (_| | (_) | |    |  __/\__ \  _ 
  \___|_|  \__, |\__,_|_| |_|\__,_|\__,_|\___/|_|     \___||___/ (_)
           |___/                                                    
 " + ganador.Apodo);

    consultaApi.GetQuote();
    var frase = consultaApi.leerFrase("cita.json");

}
 */

