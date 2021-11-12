using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progBiblioteca
{
    class Libro
    {
        public Libro(string autore, string titolo, DateTime annoPubblicazione, string editore, int numPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumPagine = numPagine;
        }

        public string Autore { get; set; }
        public string Titolo { get; set; }
        public DateTime AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumPagine { get; set; }

        public int ReadingTime()
        {
            if (NumPagine > 200)
                return 3;
            else if (NumPagine > 100)
                return 2;
            else
                return 1;
        }

        public override string ToString()
        {
            return $"Autore: {Autore}\nTitolo: {Titolo}\nAnno pubblicazione: {AnnoPubblicazione.Year}\n Editore: {Editore}\nNumero pagine: {NumPagine}";
        }
    }
}

