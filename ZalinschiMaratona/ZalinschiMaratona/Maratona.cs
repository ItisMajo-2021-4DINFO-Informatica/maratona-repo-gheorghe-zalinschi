using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZalinschiMaratona
{
    class Maratona
    {
        public List<unMaratona> elencoMaratona;
        public Maratona()
        {
            elencoMaratona = new List<unMaratona>();
        }
        public void Aggiungi(unMaratona maratona)
        {
            elencoMaratona.Add(maratona);
        }
        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("maratona.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        unMaratona maratona = new unMaratona();
                        maratona.NomeAtleta = campi[0];
                        maratona.Appartenenza = campi[1];
                        maratona.Tempo = campi[2];
                        maratona.Citta = campi[3];

                        Aggiungi(maratona);

                    }
                }
            }

        }
        public string CercaTempo(string titolo,string citta)
        {
            string artista = "--NON TROVATO--";

            foreach (var maratona in elencoMaratona)
            {
                if (maratona.NomeAtleta== titolo && maratona.Citta == citta)
                {
                    artista = maratona.Tempo;
                }
            }

            return artista;
        }
    }

}

