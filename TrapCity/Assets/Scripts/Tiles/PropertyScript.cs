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
        gm = GameManagerScript.instance();
    }

    // Upgrade the property by updating its price and house/hotel sprites.
    public void Upgrade()
    {
		if (owner.GetComponent<PlayerScript> ().GetCash () < upgradeCost)
		{
			Debug.Log("Oh no! Player doesn't have enough money to upgrade.");
			InfoScript.instance().Displayer("Oh no! Player doesn't have enough money to upgrade.");
		}
        else
            owner.GetComponent<PlayerScript>().RemvCash(upgradeCost);

        if (rentIndex < rent.Length - 1)
            rentIndex++;
    }




    /*             IBUYTILE INTERFACE                */

    //Is it owned?
    public bool IsOwned()
	{
		return (owner != null);
	}

	// Set the owner.
	public void SetOwner(GameObject player)
	{
        owner = player;
	}

    // Return owner
    public GameObject GetOwner()
    {
        return owner;
    }

	//Pay the player when pay me button has been pressed
	public void PayPlayer(GameObject payer)
	{
        payer.GetComponent<PlayerScript>().RemvCash(GetRent());
		owner.GetComponent<PlayerScript>().AddCash(GetRent());
        Debug.Log(payer.GetComponent<PlayerScript>().GetName() + " paid " + owner.GetComponent<PlayerScript>().GetName() + " " + GetRent());
		InfoScript.instance().Displayer(payer.GetComponent<PlayerScript>().GetName() + " paid " + owner.GetComponent<PlayerScript>().GetName() + " " + GetRent());
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
		Debug.Log(gm.GetCurrentPlayer().name + " has landed on " + tileName);
		InfoScript.instance().Displayer(gm.GetCurrentPlayer().name + " has landed on " + tileName);
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
                    Debug.Log("You don't have enough money.");
					InfoScript.instance ().Displayer ("You don't have enough money.");
                    return;
                }

                // Update player's cash and add to their ownership
                player.GetComponent<PlayerScript>().RemvCash(buyCost);
                player.GetComponent<PlayerScript>().GetOwnedTiles().Add(gameObject);
                player.GetComponent<PlayerScript>().IncNumProp();
                this.owner = player;
				Debug.Log(gm.GetCurrentPlayer().name + " has bought " + tileName + "!");
				InfoScript.instance().Displayer(gm.GetCurrentPlayer().name + " has bought " + tileName + "!");
            }
            else
            {
				Debug.Log(gm.GetCurrentPlayer().name + " didn't buy " + tileName);
				InfoScript.instance().Displayer(gm.GetCurrentPlayer().name + " didn't buy " + tileName);
				// auction
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
