using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SellButtonScript : MonoBehaviour
{
    private GameManagerScript gm;
    private int lastTileIndex;

    private void Start()
    {
        gameObject.SetActive(true);
        gm = GameManagerScript.instance();
    }

    public void SetLastTileIndex(int index)
    {
        lastTileIndex = index;
    }

    // Method the sell button calls
    public void PressSellButton()
    {
        try
        {
            Debug.Log("You're trying to sell " + gm.GetComponent<GameManagerScript>().GetTile(lastTileIndex).GetComponent<TileScript>().GetName());
        }
        catch (Exception e)
        {
            Debug.Log("No tile is selected!");
        }
    }
}
