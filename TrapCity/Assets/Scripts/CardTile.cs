using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTile : MonoBehaviour
{

    public GameManagerScript gm;

    void Start()
    {
        gm = GameManagerScript.instance();
    }

    //gets card when landing on tile and activates it
    public void Activate()
    {
        // need to access script component to get custom methods
        // (GetCard returns the GameObject, not CardScript)
        gm.GetCard().GetComponent<CardScript>().Activate();
    }

}
