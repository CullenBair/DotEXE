using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeParkingScript : TileScript
{
    public string descript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    /*             TILESCRIPT INHERITANCE                */

    // Buy tile option
    public override void Activate()
    {
        Debug.Log("Free parking baby");
		InfoScript.instance().Displayer("Free parking baby");
    }

    // Displaying tile info
    public override string TileInfo()
    {
        return descript;
    }
}
