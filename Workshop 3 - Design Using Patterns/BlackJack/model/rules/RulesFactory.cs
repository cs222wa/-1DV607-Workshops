using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            //return new BasicHitStrategy();
            return new Soft17strategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }        

        public IWinStrategy GetWinnerRule()
        {
            //return new EqualDealerWinsStrategy();
            return new EqualPlayerWinsStrategy();
        }
    }
}
