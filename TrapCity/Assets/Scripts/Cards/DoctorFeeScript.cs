using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorFeeScript : CardScript
{
    private GameManagerScript gm;

    public override void Activate()
    {
        Debug.Log("card name = " + cardName + "\nDescription " + text);
        gm.GetCurrentPlayer().GetComponent<PlayerScript>().AddCash(-50);
    }

    private void Start()
    {
        gm = GameManagerScript.instance();
    }
}
