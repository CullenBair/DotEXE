using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
    // The following block is singleton pattern, basically
    // it should give an access point to it from all gameobjects by calling
    // DieScript.instance();
    // see http://gameprogrammingpatterns.com/singleton.html for details
    private static DieScript instance_;
    private DieScript() {}
    public static DieScript instance()
    {
        if(instance_ == null)
            instance_ = GameObject.FindObjectOfType<DieScript>();
        return instance;
    }
    ////////////////////////////////

    public GameManager gm;
    public static const STANDARD_SIDES = 6;
    int prevDieRoll = 0;
    int die1;
    int die2;
    // player needs to know as well, so this is set to
    // true if this particular roll was a double
    bool lastDouble = false;

    void Start()
    {
        // reference to the game manager
        gm = GameManager.instance();
    }

    //rolls two dice, upadtes previous die roll and possibly calls incDouble in gamemanager
    public int RollDie(int numSides)
    {
        lastDouble = false;
        die1 = Random.Range(1, numSides+1);
        die2 = Random.Range(1, numSides+1);

        if (isDouble())
        {
            gm.incDouble();
        }

        return prevDieRoll = die1 + die2;
    }

    // method overload to handle standart sided die rolls
    public int RollDie()
    {
        lastDouble = false;
        die1 = Random.Range(1, STANDARD_SIDES+1);
        die2 = Random.Range(1, STANDARD_SIDES+1);

        if (isDouble())
        {
            gm.incDouble();
        }

        return prevDieRoll = die1 + die2;
    }

    public bool wasLastDouble()
    {
        return lastDouble;
    }

    public int GetPrevDieRoll()
    {
        return prevDieRoll;
    }

    public bool isDouble()
    {
        if(die1 == die2)
        {
            lastIsDouble = true;
            return true;
        }
        return false;
    }
}
