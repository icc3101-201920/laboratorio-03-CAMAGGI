using Laboratorio_2_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902
{
    public class Deck
    {
        private List<Card.Card> cards;
        

        public Deck()
        {

        }

        public List<Card.Card> CombatCards { get => cards; set => cards = value; }
       
        public void AddCard(Card.Card card) { throw new NotImplementedException(); }
      
        public void DestroyCard(int cardId) { throw new NotImplementedException(); }
    
        public void Shuffle() { 
            throw new NotImplementedException();
        }
    }
}
