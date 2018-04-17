using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToJailScript : TileScript
{
    public string descript;
    private GameObject player;
    private GameManagerScript gm;


    /*             TILESCRIPT INHERITANCE                */

    // sending player to jail
    public override void Activate()
    {
        Debug.Log("Get yo ass to jail");
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().SetLocIndex(10);
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().transform.position = gm.GetTile(10).transform.position;
    }

    // Displaying tile info
    public override string TileInfo()
    {
        return descript;
    }
    private void Start()
    {
        gm = GameManagerScript.instance();
    }
}
