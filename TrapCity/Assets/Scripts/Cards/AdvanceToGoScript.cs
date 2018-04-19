﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceToGoScript : CardScript
{
    private GameManagerScript gm;
    
    public override void Activate()
    {
		Debug.Log("Card name = " + cardName + "\nDescription " + text);
		InfoScript.instance().Displayer("Card name = " + cardName + "\nDescription " + text);
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().SetLocIndex(0);
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().transform.position = gm.GetTile(0).transform.position;
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().AddCash(200);
        //make this a reference to go tile
    }
    public void Start()
    {
        gm = GameManagerScript.instance(); 
    }

}
