using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int playerIndex;
    private int cash;
    private int numProperties;
    private int timeInJail;
    private int playerLocationIndex;
    private bool myTurn;

    private void Start()
    {
        //override this from game manager
        playerIndex = -1;
        timeInJail = 0;
        playerLocationIndex = 0;
    }
    
    // Request trade from another player, return true if accepted, false otherwise
    public bool RequestTrade(int playerReciever)
    {
        //person = GetComponent<PlayerPrefs>;
        //return person.RecieveTrade()

        //trade button disabled when not turn by gamemanager
        
        return false;
        
    }

    public bool RecieveTrade(int playerRequester)
    {
        //creates box in front of the parameter
        //yes / no
        //returns true/false
        //if true open trade method

        return false;
    }

    // returns money from player requested
    public void PayMe()
    {
        GameManager gm = GetComponent<GameManager>();
        Board board = GetComponent<Board>();
        // Looks for any money to be gained (penality if can't)
        int propLocationIndex = gm.playerList[gm.lastRolledPlayerIndex].playerLocationIndex; 
        if (board.owner[propLocationIndex] == this.playerIndex)
        {
            //gets money
            Tile tile = board.locations[propLocationIndex];
            cash += tile.rent[tile.rentIndex];
            //make other player pay
        }
        else
        {
            //placeholder for penalty for pressing pay me when you shouldn't
            cash -= 50;
        }

    }


}
