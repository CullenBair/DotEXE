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
    private BoardScript board;

    // enum for possible states
    private enum State { Active, Rolling, Waiting };
    State state;

    private void Start()
    {
        // setting initial state
        state = State.Waiting;
        // reference to die
        die = DieScript.instance();
        //reference to board
        board = BoardScript.instance();
        // reference to the game manager
        gm = GameManagerScript.instance();

        // inital assigns
        timeInJail = 0;
        playerLocationIndex = 0;
        cash = 1500;
        numProperties = 0;
    }

    // Rolls die, if double then state == active,
    // else state == waiting and return control
    // to gamemanger
    public void Roll()
    {
        state = State.Rolling;
        int roll;

        // Roll and move
        while (state == State.Rolling)
        {
            roll = die.RollDie();
            if (!die.wasLastDouble())
                state = State.Active;

            // Update player
            MovePlayer(roll);
        }

        EndTurn();
    }

    private void MovePlayer(int dist)
    {
        // finds how many tiles on board
        int len = gm.GetComponent<GameManagerScript>().tilesList.Length;

        // Move player tile by tile
        for (int i = 1; i <= dist; i++)
        {
            // Play position = next tile position
            transform.position = gm.GetComponent<GameManagerScript>().tilesList[(playerLocationIndex + i) % len].transform.position;

            // Add delay
        }

        playerLocationIndex = (playerLocationIndex + dist) % len;
    }

    // Starts player turn
    public void StartTurn()
    {
        state = State.Active;
        //button.SetActive(true);
        myTurn = true;
    }

    // Ends player turn
    private void EndTurn()
    {
        state = State.Waiting;
        //button.SetActive(false);
        myTurn = false;
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
        // Note: will have to check for if the tile belongs to the interface
        // IBuyTileScript, otherwise the tile will not have the GetRent function
        // as it is a method of the interface, not TileScript.

        /*
        // Looks for any money to be gained (penality if can't)
        int propLocationIndex = gm.GetPlayerList()[gm.GetLastPlayerIndex()].GetComponent<PlayerScript>().playerLocationIndex;
        TileScript lastPlayerLocation = board.GetTile(propLocationIndex).GetComponent<TileScript>();
        if (lastPlayerLocation.GetOwner().GetComponent<PlayerScript>().GetIndex() == this.playerIndex)
        {
            //gets money
            cash += lastPlayerLocation.GetRent();
            //make other player pay
        }
        else
        {
            //placeholder for penalty for pressing pay me when you shouldn't
            cash -= 50;
        }
        */
    }

    public int GetIndex()
    {
        return playerIndex;
    }

    public int GetCash()
    {
        return this.cash;
    }

    // SET the cash to a value
    public void SetCash(int cash)
    {
        this.cash = cash;
    }

    // ADD a value to the cash amount
    public void AddCash(int cash)
    {
        this.cash += cash;
    }

    public void SetPlayerIndex(int index)
    {
        this.playerIndex = index;
    }
}
