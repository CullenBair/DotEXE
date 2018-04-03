//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityScript : MonoBehaviour, TileScript, IBuyTile
{
	private int[] rent = {4,10};
	private int rentIndex;
	private int mortgagePrice;
	private bool isMortgaged;
	private DieScript die;

	//Assign the die object to "die" for referencing.
	public void Start()
	{
		//Gets reference to the die object.
		die = GameObject.FindGameObjectWithTag("Die").GetComponent<DieScript>();
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

	//Other methods:

	//Upgrade the property by updating its price and house/hotel sprites.
	public void Upgrade()
	{
		if(rentIndex != rent.Length - 1)
		{
			rentIndex++;
		}
	}
}
