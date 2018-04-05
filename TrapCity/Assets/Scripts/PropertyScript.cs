﻿//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyScript : TileScript, IBuyTile
{
	private int[] rent;
	private int rentIndex;
	private int mortgagePrice;
	private bool isMortgaged;

	//From IBuyTile:

	//Is it owned?
	public bool IsOwned()
	{
		return true;
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

		//Add upgrade sprite?
	}
}
