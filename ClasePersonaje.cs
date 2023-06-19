namespace personaje
{

    public class Personaje
    {

        private double velocidad;
        private double destreza;
        private double fuerza;
        private double nivel;
        private double armadura;
        private double salud;

        private tipo tp;
        private string? nombre;

        private string? apodo;
        private DateTime fecNac;

        private int edad;

        public double Velocidad { get => velocidad; set => velocidad = value; }
        public double Destreza { get => destreza; set => destreza = value; }
        public double Fuerza { get => fuerza; set => fuerza = value; }
        public double Nivel { get => nivel; set => nivel = value; }
        public double Armadura { get => armadura; set => armadura = value; }
        public double Salud { get => salud; set => salud = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime FecNac { get => fecNac; set => fecNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public tipo Tp { get => tp; set => tp = value; }
    }

}