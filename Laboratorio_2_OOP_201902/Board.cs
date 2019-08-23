using Laboratorio_2_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private Dictionary<string, List<Card.Card>>[] playerCards;

        private List<SpecialCard> weatherCards;

        //Propiedades
        //--------------------------------------
        public void Set(string key, List<Card.Card> value)
        {

        }


        public string Get(string key)
        {
            throw new NotImplementedException();
        }
        //--------------------------------------------------

        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.weatherCards = new List<SpecialCard>();
            this.playerCards = new Dictionary<string, List<Card.Card>>[DEFAULT_NUMBER_OF_PLAYERS];
            //Inicializa el arreglo de

            this.playerCards[0] = new Dictionary<string, List<Card.Card>>();
            //Inicializa los diccionarios.
            this.playerCards[1] = new Dictionary<string, List<Card.Card>>();
            //Inicializa los diccionarios.
        }

        //Metodos

        public void AddCard(Card.Card card, int playerId = -1, string buffType = null)
        {
            //Revisar si la carta recibida en el parmetro es Combat o Special
            if (card.GetType().Name == nameof(CombatCard))
            {
                 //En caso de que sea de combate , agregarla al diccionario del jugador correspondiente , revisando el parmetro playerId
            if (playerId == 0 || playerId == 1)
            {
            //Se revisa si el diccionario ya tiene alguna carta del tipo que se quiere agregar, por ejemplo melee.
            //Constainskey revisa si existe la llave en el diccionario.En caso de existir retorna true.Por ejemlo , si la carta es de tipo "melee",
            //el mtodo buscar si existe la llave "melee" en el
            //  diccionario.
            if (playerCards[playerId].ContainsKey(card.Type))
            {
            //Si es que existe no es necesario crear la lista de cartas, por lo que se agrega directamente
           playerCards[playerId][card.Type].Add(card);
            }
            else
            {
             //Si no existe , se agrega un nuevo par "Llave": Valor al diccionario.
            //Este par tiene como "Llave" el tipo de la carta , ejemplo "melee".
            //Este par tiene como valor la lista de cartas , con la primera carta que se va a agregar.
                 playerCards[playerId].Add(card.Type, new List<Card.Card>() { card });
            }
            }
            else
            {
                throw new IndexOutOfRangeException("No player id given");
            }
                }
            else
                {
                //Es capitan? IMPLEMENTAR
               //Revisar si no se ha agregado el capitan en el

            }




           
            
        }
        /*
        public void AddCard(Card.Card card, int playerId = -1, string buffType = null)
        {
            if (card.Type == "weather")
            {
                weatherCards.Add(card);
            }
            else
            {
                if (buffType != null)
                {
                    if (playerId == 0 || playerId == 1)
                    {
                        if (buffType == "melee")
                        {
                            specialMeleeCards[playerId] = specialCard;
                        }
                        else if (buffType == "range")
                        {
                            specialRangeCards[playerId] = specialCard;
                        }
                        else
                        {
                            specialLongRangeCards[playerId] = specialCard;
                        }
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }   
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public void DestroyCombatCards()
        {
            this.meleeCards = new List<Card.Card>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<Card.Card>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<Card.Card>[DEFAULT_NUMBER_OF_PLAYERS];
        }
        public void DestroySpecialCards()
        {
            this.specialMeleeCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
            this.specialRangeCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
            this.specialLongRangeCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
        }
        public int[] GetMeleeAttackPoints()
        {
            //Debe sumar todos los puntos de ataque de las cartas melee y retornar los valores por jugador.
            int[] totalAttack = new int[] { 0, 0 };
            for (int i=0; i < 2; i++)
            {
                foreach (CombatCard meleeCard in meleeCards[i])
                {
                    totalAttack[i] += meleeCard.AttackPoints;
                }
            }
            return totalAttack;
            
        }
        public int[] GetRangeAttackPoints()
        {
            //Debe sumar todos los puntos de ataque de las cartas range y retornar los valores por jugador.
            int[] totalAttack = new int[] { 0, 0 };
            for (int i = 0; i < 2; i++)
            {
                foreach (CombatCard rangeCard in rangeCards[i])
                {
                    totalAttack[i] += rangeCard.AttackPoints;
                }
            }
            return totalAttack;
        }
        public int[] GetLongRangeAttackPoints()
        {
            //Debe sumar todos los puntos de ataque de las cartas longRange y retornar los valores por jugador.
            int[] totalAttack = new int[] { 0, 0 };
            for (int i = 0; i < 2; i++)
            {
                foreach (CombatCard longRangeCard in longRangeCards[i])
                {
                    totalAttack[i] += longRangeCard.AttackPoints;
                }
            }
            return totalAttack;
        }
        */
    }
}
