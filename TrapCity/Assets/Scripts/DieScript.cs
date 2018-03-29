using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
    public GameManager gm;

    int prevDieRoll = 0;
    int die1;
    int die2;
    
    //rolls two dice, upadtes previous die roll and possibly calls incDouble in gamemanager
    public int RollDie(int numSides)
    {
        die1 = Random.Range(1, numSides+1);
        die2 = Random.Range(1, numSides+1);

        if (isDouble())
        {
            gm.incDouble();
        }

        return prevDieRoll = die1 + die2;
    }

    public int GetPrevDieRoll()
    {
        return prevDieRoll;
    }

    public bool isDouble()
    {
        return (die1 == die2);
    }
}
