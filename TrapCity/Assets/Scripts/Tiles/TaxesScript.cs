//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxesScript : TileScript
{
    public string descript;
    private PlayerScript player;


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



    /*             TILESCRIPT INHERITANCE                */

    // Tax either 200 or 10%.
    public override void Activate()
    {
        Debug.Log("You've been taxed 200!");

        /*
        if (player.GetCash() >= 200)
		{
            ;
		}
		else
		{
			TaxTenPercent(player);
		}
        */
    }

    // Displaying tile info
    public override string TileInfo()
    {
        return descript;
    }
}
