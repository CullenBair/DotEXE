using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToJailScript : TileScript
{
    public string descript;
    private GameObject player;



    /*             TILESCRIPT INHERITANCE                */

    // sending player to jail
    public override void Activate()
    {
        Debug.Log("Get yo ass to jail");
    }

    // Displaying tile info
    public override string TileInfo()
    {
        return descript;
    }
}
