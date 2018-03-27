using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadScript : MonoBehaviour {

    private GameObject[] tiles;

    private void Start()
    {
       tiles = GameObject.FindGameObjectsWithTag("Tile");
    }

    // Moves player avatar
    public void MovePlayerTo()
    {
        // Get player from gamemanger players array, move position by dice roll
    }

}
