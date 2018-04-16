//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailroadScript : TileScript, IBuyTile
{
    public int buyCost;
    public int[] rent;
    public int mortgageValue;
    public GameObject[] linkedTiles;

    private int rentIndex;
    private bool isMortgaged;
    private GameObject owner;




    /*             IBUYTILE INTERFACE                */

    //Is it owned?
    public bool IsOwned()
    {
        return true;
    }

    //Set the owner.
    public void SetOwner(PlayerScript player)
    {
        //
    }

    //Pay the player.
    public void PayPlayer(PlayerScript player)
    {
        player.SetCash(player.GetCash() + GetRent());
    }

    //This property is now mortgaged.
    public void ToMortgaged()
    {
        isMortgaged = true;
    }

    //This property is now not mortgaged.
    public void FromMortgaged()
    {
        isMortgaged = false;
    }

    //Is this property mortgaged?
    public bool GetIsMortgaged()
    {
        return isMortgaged;
    }

    //Return the propety's current rent.
    public int GetRent()
    {
        return rent[rentIndex];
    }

    // Return price of tile
    public int GetCost()
    {
        return buyCost;
    }



    /*             TILESCRIPT INHERITANCE                */

    // Buy tile option
    public override void Activate()
    {
        Debug.Log("You landed on a railroad");
    }

    // Displaying tile info
    public override string TileInfo()
    {
        string s = "Purchase cost: \n\t$" + buyCost + "\n\n";

        s += "Rent price: \n";
        for (int i = 0; i < rent.Length; i++)
            s += "\t$" + rent[i] + "\n";
        s += "\n";

        s += "Mortgage value: \n\t$" + mortgageValue + "\n\n";

        s += "Family tiles: \n";
        for (int i = 0; i < linkedTiles.Length; i++)
            s += "\t" + linkedTiles[i].GetComponent<TileScript>().GetName() + "\n";

        return s;
    }
}
