//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxScript : TileScript
{

	private PlayerScript player;

	// Tax either 200 or 10%.
	public override void Activate()
	{
		if(player.GetCash() >= 200)
		{
			// Player chooses how they're taxed.
		}
		else
		{
			TaxTenPercent(player);
		}
	}

	// Deducts the player's money by 200.
	void TaxTwoHundred(PlayerScript player)
	{
		player.SetCash(player.GetCash() - 200);
	}

	// Deducts the player's money by 10%.
	void TaxTenPercent(PlayerScript player)
	{
		player.SetCash(player.GetCash() - (player.GetCash() / 10));
	}
}
