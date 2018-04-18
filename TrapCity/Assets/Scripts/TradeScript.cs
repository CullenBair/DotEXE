using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class TradeScript : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	// containers holding offers from both players
	// probabaly should only call this when player selects somemthing
	public Text p1Offer;
	public Text p2Offer;
	// cash offer
	public int p1CashOffer;
	public int p2CashOffer;
	//
	public int p1TileOffer;
	public int p2TileOffer;

	private bool newUpdate;

	// need to add method to gamemanager to call when trade button is pressed and p2 accepts, activating this gameobject.

	// p1 should be assigned from whatever way we get a reference to the local player
	// p2 assigned by whoever is currently selected by the info panel

	void Start()
	{
		// update p1 with local player
	}

	void OnEnable()
	{
		// add player properties to dropdown
		// UpdateDropDown();
	}

	// called from playerinfo script every time the player whos information is
	// displayed
	public void UpdateSelectedPlayer(GameObject player)
	{
		p2 = player;
	}

	private void UpdateDropDown()
	{
		// prop_drop.AddOptions()
		// https://docs.unity3d.com/ScriptReference/UI.Dropdown.AddOptions.html
	}

	public void AcceptTrade()
	{
		// wait until both players press accept and
	}

	public void DeclineTrade()
	{
		// quit and send message to other player saying p1 denied
	}

	public void StartTrade(GameObject p2)
	{
		this.p2 = p2;

		// NOTE:  send this message to p2
		bool response = EditorUtility.DisplayDialog("Trade Request", (p1.name + " wants to initiate a trade with you."), "Do it!", "Nope." );

		if(response == false)
			// NOTE: make custom text popup instead
			EditorUtility.DisplayDialog("Request Denied", (p2.name + " has denied your request."), "Well that sucks!", "Okay." );
		else // display trade dialog
			print("not yet implemented");

	}


}
	//
	// // p2 designated by player button selected in player info ui
	// // p1 is this player
	// // p1 clicks Trade button
	// // Prompt p2 with dialog window
	// //		YES: bring up trade ui for p1 and p2
	// //		NO: send p1 dialog box saying "they said fuck u boi"
	//
