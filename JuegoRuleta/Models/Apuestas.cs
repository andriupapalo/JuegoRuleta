using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JuegoRuleta.Models
{

    public class Apuestas
    {
        public string id { get; set; }
        public string cliente { get; set; }
        public string ruleta { get; set; }
        public ICollection<Colorul> colores { get; set; }
        public ICollection<numerorul> numeros { get; set; }
        public int valorapostado { get; set; }

        /*public Apuestas()
        {

        }
        */
                public Apuestas(string cliente, string ruleta, ICollection<Colorul> colores, ICollection<numerorul> numeros, int valorapostado)
                {
                    this.cliente = cliente;
                    this.ruleta = ruleta;
                    this.colores = colores;
                    this.numeros = numeros;
                    this.valorapostado = valorapostado;
                }

        public Apuestas()
        {
        }

        internal void Add(Apuestas apuestas)
        {
            throw new NotImplementedException();
        }
        internal void ArmarLista()
        {
            List<Apuestas> apuesta = new List<Apuestas>();
        }
    }
    
}
/*
*************************************************************
private class Alumno
{
    public int id;
    public string nombre;
    public List<Calificaciones> calificacionesMensuales;
    public Alumno(int id, string nombre, List<Calificaciones> calificacionesMensuales)
    {
        this.id = id;
        this.nombre = nombre;
        this.calificacionesMensuales = calificacionesMensuales;
    }
}

private class Calificaciones
{
    public int mes;
    public string materia;
    public int nota;
    public Calificaciones(int mes, string materia, int nota)
    {
        this.mes = mes;
        this.materia = materia;
        this.nota = nota;
    }
}

public void ArmarLista()
{
    List<Alumno> alumnos = new List<Alumno>();
    alumnos.Add(new Alumno(1, "pablito", new Calificaciones(2, "matematicas", 1)));

}*/
