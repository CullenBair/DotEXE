//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxesScript : TileScript
{
	private PlayerScript player;

	// Tax either 200 or 10%.
	public override void Activate()
	{
        // Attach player who activated tile
        player = null;

		if (player.GetCash() >= 200)
		{
            // Player chooses how to pay?
            TaxTwoHundred(player);
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
