using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class TradeScript : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;

	// list of owned tiles and names for the dropdown
	private List<GameObject> p2Owned;
	private List<string> p2OwnedNames;
	Dropdown.OptionData data = new Dropdown.OptionData();

	public Dropdown prop_drop;

	// p1 should be assigned from whatever way we get a reference to the local player
	// p2 assigned by whoever is currently selected by the info panel

	void Awake()
	{
		p1 = GameManagerScript.instance().GetPlayerList()[0];
		// update p1 with local player
	}

	void OnEnable()
	{
		//p1 = this.gameObject; // just for now
		// need reference to player
		StartTrade(GameManagerScript.instance().info_player);
		// add player properties to dropdown
		UpdateDropDown();
	}

	// called from playerinfo script every time the player whos information is
	// displayed
	public void UpdateSelectedPlayer(GameObject player)
	{
		p2 = player;
	}

	private void UpdateDropDown()
	{
		prop_drop.ClearOptions();

		p2Owned = p2.GetComponent<PlayerScript>().GetOwnedTiles();

		if(p2Owned.Count > 0)
		{
			foreach(GameObject g in p2Owned)
			{
				data.text = g.name;
				//p2OwnedNames.Add(g.name);
			}

			prop_drop.options.Add(data);
			// https://docs.unity3d.com/ScriptReference/UI.Dropdown.AddOptions.html
		}
	}

	public void AcceptTrade()
	{
		// wait until both players press accept and
	}

	public void StartTrade(GameObject p2)
	{
		this.p2 = p2;

		// NOTE:  send this message to p2
		bool response = EditorUtility.DisplayDialog("Trade Request", (p1.name + " wants to initiate a trade with you."), "Do it!", "Nope." );

		if(response == false)
		{
			RejectTrade();
		}
		else // display trade dialog
			transform.GetChild(0).gameObject.SetActive(true);

	}

	// reject pop up window, disable this after timer
	public void RejectTrade()
	{
		transform.GetChild(1).gameObject.SetActive(true);
		transform.GetChild(1).gameObject.GetComponent<TextPopup>().DisableMe();
	}


}
