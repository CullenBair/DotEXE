using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailScript : TileScript
{
    private int escapeRollNum;
    // need to set bail price
    private int bailPrice;

    // standard activation method
    public override void Activate()
    {
            // Nothing happens when one lands on jail right?
    }

    // get bail price
    public int GetBailPrice()
    {
        return bailPrice;
    }

    // Increments how many turns the player has been in jail. Game manager will need to determine
    // if the player needs to force the player to pay the bail after three rolls
    public int IncrementEscapeRollNum()
    {
        escapeRollNum++;
        return escapeRollNum;
    }
}
