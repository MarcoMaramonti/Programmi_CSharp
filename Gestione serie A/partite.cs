using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gestione_serie_A
{
    public struct Squadra
    {
        public string nome;
        public int goal;
    }

    public class partite
    {
        //Attributi
        public Squadra[,] tab;
        public int ns;

        //Costruttore
        public partite()
        {
            tab = new Squadra[10, 2];
            ns = 0;
        }

        //Carica partite
        public bool carica(string nome_f)
        {
            if (File.Exists(nome_f) == false)
                return false;

            StreamReader sr = new StreamReader(nome_f);
            string riga;
            while ((riga = sr.ReadLine()) != null)
            {
                string[] pezzi = riga.Split('-');
                tab[ns,0].nome = pezzi [0];
                tab[ns, 0].goal = 0;
                tab[ns, 1].nome = pezzi[1];
                tab[ns, 1].goal = 0;
                ns++;
            }
            return true;
        }
    }
}
