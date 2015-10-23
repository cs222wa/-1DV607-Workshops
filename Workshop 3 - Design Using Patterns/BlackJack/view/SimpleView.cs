using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : IView
    {
        private const char m_playChar = 'p';
        private const char m_hitChar = 'h';
        private const char m_standChar = 's';
        private const char m_quitchar = 'q';
                        
        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.WriteLine("Type {0} to Play, {1} to Hit, {2} to Stand or {3} to Quit\n", m_playChar, m_hitChar, m_standChar, m_quitchar);  //--------
        }

        public Event GetEvent()
        {
            switch (System.Console.In.Read())
            {
                case m_playChar:
                    return Event.Play;
                case m_hitChar:
                    return Event.Hit;
                case m_standChar:
                    return Event.Stand;
                case m_quitchar:
                    return Event.Quit;
                default:
                    return Event.None;
            }
        }       

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void PauseRedraw()
        {
            System.Console.WriteLine("Dealing Card...");
            System.Threading.Thread.Sleep(2000);

        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }            
        }
    }
}
