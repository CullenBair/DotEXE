using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankErrorScript : CardScript
{
    private GameManagerScript gm;

    public override void Activate()
    {
        Debug.Log("card name = " + cardName + "\nDescription " + text);
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().AddCash(200);
    }

    private void Start()
    {
        gm = GameManagerScript.instance();
    }

}
