using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTile : TileScript
{
    public string descript;
    private GameManagerScript gm;

    void Start()
    {
        gm = GameManagerScript.instance();
    }



    /*             TILESCRIPT INHERITENCE           */

    // Pull a card
    public override void Activate()
    {
        //Debug.Log("You've pulled a card!");
        // need to access script component to get custom methods
        // (GetCard returns the GameObject, not CardScript)
    //    gm.GetCard().GetComponent<CardScript>().Activate();
        return;
    }

    // Displaying tile info
    public override string TileInfo()
    {
        return descript;
    }

}
