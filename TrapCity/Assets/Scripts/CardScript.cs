using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardScript : MonoBehaviour
{
    //private GameManagerScript gm;

    public string cardName;
    public bool useImmediately;
    public string text;

    public abstract void Activate();
        
}