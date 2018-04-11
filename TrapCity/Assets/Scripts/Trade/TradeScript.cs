using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TradeScript : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;

	void Start()
	{
		p1 = this.gameObject;
		StartTrade(this.gameObject);
	}

	public void StartTrade(GameObject p2)
	{
		this.p2 = p2;

		// send this message to p2
		bool response = EditorUtility.DisplayDialog("Trade Request", (p1.name + " wants to initiate a trade with you."), "Do it!", "Nah fam." );

		if(response == false)
			EditorUtility.DisplayDialog("Request Denied", (p2.name + " has denied your request."), "Well that sucks!", "That's ok... I guess" );
		else // display trade dialog
			print("not yet implemented");

		// prompt p2 w/ decision
		// if yes, trade dialog
		// if no, return p1 a fuck u dialog
	}

	// p2 designated by player button selected in player info ui
	// p1 is this player
	// p1 clicks Trade button
	// Prompt p2 with dialog window
	//		YES: bring up trade ui for p1 and p2
	//		NO: send p1 dialog box saying "they said fuck u boi"


}
