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
    private GameManagerScript gm;
    private DieScript die;

    // enum for possible states
    private enum State { Active, Rolling, Waiting };

    private void Start()
    {
        // setting initial state
        State state = State.Waiting;
        // reference to die
        die = DieScript.instance();
        // reference to the game manager
        gm = GameManager.instance();
        //override this from game manager
        playerIndex = -1;
        timeInJail = 0;
        playerLocationIndex = 0;
    }

    // Rolls die, if double then state == active,
    // else state == waiting and return control
    // to gamemanger
    public void Roll()
    {
        int roll = die.RollDie();
        if(die.wasLastDouble())
            // NOTE: THIS SHOULD BE SET TO ACTIVE. HAVE NOT FIGURED OUT HOW TO DEAL WITH
            // THE DOUBLE ROLL STATE. FOR NOW WILL JUST IMMEDIATELY ROLL
            state = State.Rolling;
        else
            state = State.Active;
    }

    // Starts player turn
    public void StartTurn()
    {
        state = State.Active;
    }

    // Ends player turn
    private void EndTurn();
    {
        state = State.Waiting;
        gm.NextTurn();
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
