//Matthew Drabek
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuyTile
{
	bool IsOwned();
	void SetOwner(PlayerScript player);
	void PayPlayer(PlayerScript player);
	void ToMortgaged();
	void FromMortgaged();
	bool GetIsMortgaged();
	int GetRent();
}