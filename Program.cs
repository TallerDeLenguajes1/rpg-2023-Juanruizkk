// See https://aka.ms/new-console-template for more information
using FabPersonaje;
using pje;
using System.Collections.Generic;
using System.IO;
using EspacioFabPalabras;


/* private string Centrar(string palabra, int espacios)
{
    int Blanco = (espacios - palabra.Length) / 2;
    string palabraCentrada = palabra.PadLeft(palabra.Length + Blanco);
    palabraCentrada = palabraCentrada.PadRight(espacios);
    return palabraCentrada;
}
private string Numero(float num)
{
    string aux;
    if (num < 10)
    {
        aux = "  " + num;
    }
    else
    {
        if (num < 100)
        {
            aux = " " + num;
        }
        else
        {
            aux = num.ToString();
        }
    }
    return aux;
}
public void MostrarPersonaje()
{
    string aux = "¤ " + Nombre + ", " + Apodo + " ¤";
    string aux3 = "«LVL: " + Nivel + "»";
    string aux2;
    string signo = "<O>";
    if (Tipo != null)
    {
        aux2 = "«" + Tipo.Split()[1] + "»";
        switch (Tipo.Split(',')[0])
        {
            case "Humano":
                signo = "HUM";
                break;
            case "Elfo":
                signo = "ELF";
                break;
            case "Muerto Viviente":
                signo = "MVT";
                break;
            case "Orco":
                signo = "ORC";
                break;
            default:
                signo = "<O>";
                break;
        }
    }
    else
    {
        aux2 = "«" + "" + "»";
    }
    System.Console.WriteLine("╔══════════════════════════════════════════╗");
    System.Console.WriteLine("║" + Centrar(aux, 42) + "║");
    System.Console.WriteLine("║" + Centrar(aux2, 18) + "╔═══╗" + Centrar(aux3, 19) + "║");
    System.Console.WriteLine("╚═════════════════╗║" + signo + "║╔══════════════════╝");
    System.Console.WriteLine("╔═════════════════╝╚═══╝╚══════════════════╗");
    System.Console.WriteLine("║             »CARACTERISTICAS«            ║");
    System.Console.WriteLine("║               ├>Vida: " + Numero(Salud) + "                ║");
    System.Console.WriteLine("║               ├>Dest: " + Numero(Destreza) + "                ║");
    System.Console.WriteLine("║               ├>Frza: " + Numero(Fuerza) + "                ║");
    System.Console.WriteLine("║               ├>Velc: " + Numero(Velocidad) + "                ║");
    System.Console.WriteLine("║               ├>Armd: " + Numero(Armadura) + "                ║");
    System.Console.WriteLine("║               └>Armd: " + Numero(Edad) + "                ║");
    System.Console.WriteLine("║                »ESPECIAL«                ║");
    aux = "< " + Especial + " >";
    System.Console.WriteLine("║" + Centrar(aux, 42) + "║");
    System.Console.WriteLine("╚══════════════════════════════════════════╝");
} */
string directory = @"C:\Juan Ruiz\Taller 1\C#\rpg-2023-Juanruizkk";

List<Personaje> listaPersonajes = new List<Personaje>();
string fileName = "personajes.json";
var jsonPlayers = new personajeJSON(); // Creo instancia clase personajeJSON


jsonPlayers.nuevaPartida(directory);

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

    /*     var frase = consultaApi.leerFrase("cita.json");
        System.Console.WriteLine(frase.Quote); */
}


