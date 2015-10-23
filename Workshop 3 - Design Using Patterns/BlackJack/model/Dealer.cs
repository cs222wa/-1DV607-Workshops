﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Dealer : Player
    {
        private Deck m_deck = null;
        private const int g_maxScore = 21;

        private rules.INewGameStrategy m_newGameRule;
        private rules.IHitStrategy m_hitRule;
        private rules.IWinStrategy m_winnerRule;

        List<BlackJackObserver> m_observers;
        
        public Dealer(rules.RulesFactory a_rulesFactory)
        {
            m_newGameRule = a_rulesFactory.GetNewGameRule();
            m_hitRule = a_rulesFactory.GetHitRule();
            m_winnerRule = a_rulesFactory.GetWinnerRule();
            m_observers = new List<BlackJackObserver>();

        }

        public bool NewGame(Player a_player)
        {
            if (m_deck == null || IsGameOver())
            {
                m_deck = new Deck();
                ClearHand();
                a_player.ClearHand();
                return m_newGameRule.NewGame(this, a_player);   
            }
            return false;
        }

        public void AddSubscriber(BlackJackObserver a_subscriber)
        {
            m_observers.Add(a_subscriber);
        }

        public bool Hit(Player a_player)
        {
            if (m_deck != null && a_player.CalcScore() < g_maxScore && !IsGameOver())
            {
                
                getShowDealCard(a_player, true);
                return true;
            }
            return false;
        }

        public bool IsDealerWinner(Player a_player)
        {
            return m_winnerRule.IsDealerWinner(a_player, this, g_maxScore); 
        }
        

        public bool IsGameOver()
        {
            if (m_deck != null && m_hitRule.DoHit(this) != true)
            {
                return true;
            }
            return false;
        }

        public bool Stand(Player a_player)
        {
            if (m_deck != null)
            {
                ShowHand();
                while (m_hitRule.DoHit(this)) 
                {
                   getShowDealCard(a_player, true);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void getShowDealCard(Player a_player, Boolean show)
        {
            Card c = m_deck.GetCard();
            c.Show(show);
            a_player.DealCard(c);
            foreach (BlackJackObserver o in m_observers)
            {
                o.CardDealt();
            }
            
        }
    }
}
