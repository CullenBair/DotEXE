//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityScript : TileScript, IBuyTile
{
	private int[] rent = {4,10};
	private int rentIndex;
	private int mortgagePrice;
	private bool isMortgaged;
	private DieScript die;

	public override void Activate()
	{
		print("Activate not yet implemented");
	}

	//Assign the die object to "die" for referencing.
	public void Start()
	{
		//Gets reference to the die object.
		die = DieScript.instance().GetComponent<DieScript>();
	}

	//From IBuyTile:

	//Is it owned?
	public bool IsOwned()
	{
		return GetOwner() != null;
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

	//Return the rent amount based on the previous die roll and the rent index multiplier.
	public int GetRent()
	{
		return die.GetPrevDieRoll() * rent[rentIndex];
	}

	//Return the property's rent index.
	public int GetRentIndex()
	{
		return rentIndex;
	}

	//Upgrade the property by updating its price and house/hotel sprites.
	public void Upgrade()
	{
		if(rentIndex != rent.Length - 1)
		{
			rentIndex++;
		}
	}
}
