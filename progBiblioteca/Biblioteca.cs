using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progBiblioteca
{
    class Biblioteca
    {
        public Biblioteca(string nome, string indirizzo, DateTime apertura, DateTime chiusura, List<Libro> libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Apertura = apertura;
            Chiusura = chiusura;
            Libri = libri;
        }

        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Chiusura { get; set; }  
        public List<Libro> Libri { get; set; }
    }
}
