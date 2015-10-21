using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17strategy : IHitStrategy
    {
        private const int g_hitLimit = 17;
        public bool DoHit(model.Player a_dealer)
        {
            var cards = a_dealer.GetHand();
            var score = a_dealer.CalcScore();
            if (score == g_hitLimit)
            {
                foreach (var card in cards)
                {
                    if (card.GetValue() == Card.Value.Ace && score - 11 == 6)
                    {
                        score -= 10;                        
                    }
                    return score < g_hitLimit;
                }
            }
            return false;
        }
    }
}
