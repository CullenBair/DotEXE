using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTile : MonoBehaviour
{

    public GameManager gm;

    //gets card when landing on tile and activates it
    public void Activate()
    {
        gm.GetCard().Activate();
    }

}
