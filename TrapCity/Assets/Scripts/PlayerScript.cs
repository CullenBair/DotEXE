using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int cash;
    private string playerName;
    private int numProperties;
    private int timeInJail;
    private int playerLocation;
    private bool myTurn;

    private void Start()
    {
        timeInJail = 0;
    }
    
    // Request trade from another player, return true if accepted, false otherwise
    public bool RequestTrade(string playerName)
    {
        return false;
    }

    // returns money from player requested
    public void PayMe(string playerName)
    {
        cash += 0;
    }

}
