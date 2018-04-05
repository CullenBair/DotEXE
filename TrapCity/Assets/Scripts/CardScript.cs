using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// No longer needs to be abstract, all decks will be of type card. 
public class CardScript : MonoBehaviour
{
    public GameObject gm;
    public bool useImmediately;
    public string text;
    string cardName;

    public void Activate()
    {

    }
}
