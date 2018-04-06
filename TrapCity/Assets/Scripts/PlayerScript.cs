using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int playerIndex;
    public int cash;
    public int numProperties;
    private int timeInJail;
    private int playerLocationIndex;
    private bool myTurn;
    public string playerName;
    private GameManagerScript gm;
    private DieScript die;
    private BoardScript board;
    public Text playerInfoText;
    public int playerIndexText;
    public List<GameObject> ownedTiles;

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
        //override this from game manager
        playerIndex = -1;
        timeInJail = 0;
        playerLocationIndex = 0;

        playerInfoText.text = "init";
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
    private void EndTurn()
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

    void Update()
    {
        //UpdateText();
    }

    public void UpdateText()
    {
        playerInfoText.text = playerName + " cash: $" + cash;
        playerInfoText.text += "\n";
        playerInfoText.text += "properties: " + numProperties;
        if (ownedTiles.Count != 0)
        {
            playerInfoText.text += "\nOwned Properties:\n";
            foreach(GameObject tile in ownedTiles)
            {
                playerInfoText.text += " " + tile.name + "\n";
            }
        }
    }

}
