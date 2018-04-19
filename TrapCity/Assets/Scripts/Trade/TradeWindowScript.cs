using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeWindowScript : MonoBehaviour
{

	public Text p1OfferText;
	public Text p2OfferText;
	public int p1CashOffer;
	public int p2CashOffer;
	public int p1TileOffer;
	public int p2TileOffer;

	private bool newUpdate;

	void Start()
	{
		newUpdate = false;
	}

	void Update()
	{
		// probabaly should only call this when player selects somemthing
		if(newUpdate)
		{
			UpdateText();
		}
	}

	public void UpdateText()
	{

	}

	public void AcceptTrade()
	{

	}

	public void DeclineTrade()
	{

	}

}
