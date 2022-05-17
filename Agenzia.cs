using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico, 
- indirizzo, 
- cap, 
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti 
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.

 */
namespace csharp_agenzia
{
    internal class Agenzia
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }
        private List<Immobile> listaImmobili { get; set; }
        


        // COSTRUTTORE  
        public Agenzia(string nome)
        { 
            this.Nome = nome;   
            listaImmobili = new List<Immobile>();
            
        }

        //  METODO PER AGGIUNGERE UN IMMOBILE
        public void AddImmobile(Immobile i)
        { 
            listaImmobili.Add(i);
        }


        // METODO PER CERCARE UN IMMOBILE
        public void CercaImmobile(string codice)
        {
            foreach (Immobile item in listaImmobili)
            {
                if (item.Codice == codice)
                {
                    Console.WriteLine("l'immobile e presente nel DB dell'agenzia");
                    return;
                }
                else
                {
                    Console.WriteLine("L'immobile cercato non e disponibile");
                    return;
                }
            }
        }


        // SECONDO METODO PER CERCARE UN IMMOBILE INSERENDO QUALSIASI PARAMETRI
        public List<Immobile> SearchImmobili(string key)
        {
            return this.listaImmobili.FindAll(i => i.Contains(key));
        }
    }

}
