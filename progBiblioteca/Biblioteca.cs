using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progBiblioteca
{
    class Biblioteca
    {

        public Biblioteca(string nome, string indirizzo, DateTime apertura, DateTime chiusura): this(nome, indirizzo, apertura, chiusura, new List<Libro>()) { }
        
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

        public void AggiungiLibro(Libro l)
        {
            Libri.Add(l);
        }

        public Libro CercaLibroTitolo(string titolo)
        {
            foreach (Libro libro in Libri)
            {
                if (libro.Titolo == titolo) return libro;
            }

            return null;
        }

        public List<Libro> CercaLibriAutore(string autore)
        {
            List<Libro> trovati = new List<Libro>();
            foreach (Libro libro in Libri)
            {
                if (libro.Autore == autore)
                    trovati.Add(libro);
            }

            return trovati;
        }

        public int NumeroLibri()
        {
            return Libri.Count;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nIndirizzo: {Indirizzo}\nApertura: {Apertura.Hour}:{Apertura.Minute}\nChiusura: {Chiusura.Hour}:{Chiusura.Minute}\nNumero libri: {NumeroLibri()}";
        }
    }
}
