using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardScript : MonoBehaviour
{
    public GameObject gm;

    string cardName;
    bool useImmediately;
    string text;

    public abstract void Activate();

}
