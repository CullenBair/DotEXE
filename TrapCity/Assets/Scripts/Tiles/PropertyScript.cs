//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PropertyScript : TileScript, IBuyTile
{
    public int buyCost;
	public int[] rent;
    public int upgradeCost;
    public int mortgageValue;
    public GameObject[] linkedTiles;

    private int rentIndex;
	private bool isMortgaged;
    private GameObject owner;
    private GameManagerScript gm;

    public void Start()
    {
        owner = null;
        gm = GameManagerScript.instance();
    }

    // Upgrade the property by updating its price and house/hotel sprites.
    public void Upgrade()
    {
        if (rentIndex != rent.Length)
        {
            rentIndex++;
        }

        // Add upgrade sprite?
    }



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
		player.AddCash(GetRent());
	}

	// This property is now mortgaged.
	public void ToMortgaged()
	{
		isMortgaged = true;
	}

	// This property is now not mortgaged.
	public void FromMortgaged()
	{
		isMortgaged = false;
	}

	// Is this property mortgaged?
	public bool GetIsMortgaged()
	{
		return isMortgaged;
	}

	// Return the propety's current rent.
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

    // Buying process
    public override void Activate()
    {
         // If the tile doesn't have an owner, ask to buy
        if (owner == null)
        {
            bool response = EditorUtility.DisplayDialog(tileName, ("Would you like to buy this tile for " + buyCost + "?"), "Yes", "No");

            // If they did want to buy
            if (response == true)
            {
                GameObject player = gm.GetComponent<GameManagerScript>().GetCurrentPlayer();
                int playerCash = player.GetComponent<PlayerScript>().GetCash();

                if (playerCash < buyCost)
                {
                    Debug.Log("You don't have enough money");
                    return;
                }

                // Update player's cash and add to their ownership
                player.GetComponent<PlayerScript>().SetCash(playerCash - buyCost);
                player.GetComponent<PlayerScript>().GetOwnedTiles().Add(gameObject);
                player.GetComponent<PlayerScript>().IncNumProp();
                owner = player;
                Debug.Log("Player has bought this property!");
            }
        }
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
