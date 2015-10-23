using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame : model.BlackJackObserver
    {        
        view.IView a_view;

        public PlayGame(view.IView m_view)
        {
            a_view = m_view;
        }

        public bool Play(model.Game a_game)
        {
            a_game.AddSubscriber(this);

            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }
                        
            view.Event e;
            e = a_view.GetEvent();

            if (e == view.Event.Play)
            {
                a_game.NewGame();
            }
            else if (e == view.Event.Hit)
            {
                a_game.Hit();
            }
            else if (e == view.Event.Stand)
            {
                a_game.Stand();
            }

            return e != view.Event.Quit;
        }

        public void CardDealt()
        {
            a_view.PauseRedraw();
        }
    }
}
