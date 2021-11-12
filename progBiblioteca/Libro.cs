using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progBiblioteca
{
    class Libro
    {
           
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumPagine { get; set; }

        public override string ToString()
        {
            //
            return $"Autore: {Autore}\nTitolo: {Titolo}\nAnno pubblicazione: {AnnoPubblicazione}\n Editore: {Editore}\nNumero pagine: {NumPagine}";
        }
        
    }
}

