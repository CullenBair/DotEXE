//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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

    // Upgrade the property
    public void Upgrade(int index)
    {
        // If it can be upgraded
        if (rentIndex >= rent.Length - 1)
        {
            Debug.Log("You cannot upgrade further.");
            return;
        }

        // If player has enough money
        if (owner.GetComponent<PlayerScript>().GetCash() < upgradeCost)
        {
            Debug.Log("Oh no, player doesn't have enough money to upgrade.");
            return;
        }


        owner.GetComponent<PlayerScript>().RemvCash(upgradeCost);
        rentIndex++;
        gm.GetTileButton(index).GetComponentInChildren<Text>().text = rentIndex.ToString();
    }

    public void SellUpgrade(int index)
    {
        if (rentIndex <= 0)
        {
            Debug.Log("There are no upgrades to sell.");
            return;
        }

        // Give player cash 
        owner.GetComponent<PlayerScript>().AddCash(upgradeCost / 2);

        rentIndex--;
        gm.GetTileButton(index).GetComponentInChildren<Text>().text = rentIndex.ToString();
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
    }

	// This property is now mortgaged.
	public void ToMortgaged()
	{
        if (rentIndex != 0)
            Debug.Log("You need to have no upgrades to mortgage.");

        owner.GetComponent<PlayerScript>().AddCash(mortgageValue);
        isMortgaged = true;
	}

	// This property is now not mortgaged.
	public void FromMortgaged()
	{
        owner.GetComponent<PlayerScript>().RemvCash(mortgageValue + (mortgageValue / 10));

        isMortgaged = false;
	}

    // Decides how to handle mortgaging
    public void Mortgage()
    {
        // Already mortgaged
        if (isMortgaged == true)
        {
            if (owner.GetComponent<PlayerScript>().GetCash() > mortgageValue + (mortgageValue / 10))
            {
                Debug.Log("Bought back property from mortgage.");
                FromMortgaged();
                return;
            }
            else
            {
                Debug.Log("You don't have enough money to buy from mortgage.");
                return;
            }
        }

        ToMortgaged();
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
                player.GetComponent<PlayerScript>().RemvCash(buyCost);
                player.GetComponent<PlayerScript>().GetOwnedTiles().Add(gameObject);
                player.GetComponent<PlayerScript>().IncNumProp();
                this.owner = player;
                Debug.Log(gm.GetCurrentPlayer().name + " has bought " + tileName + "!");
            }
            else
            {
                Debug.Log(gm.GetCurrentPlayer().name + "didn't buy" + tileName);
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
