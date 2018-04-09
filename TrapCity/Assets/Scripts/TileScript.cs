using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Joseph Peaden

public abstract class TileScript : MonoBehaviour {

    private string tileName;
    // contains linked
    private List<GameObject> linkedTiles;
    private GameObject owner;
    private int buyCost;

    private void Start()
    {
        // originally, owner is nobody
        owner = null;
    }

    // wrapper/overridden method for each type of tile to activate their
    // particular behaviour
    public abstract void Activate();

    // get name of tile
    public string GetName()
    {
        return tileName;
    }

    // Check all linked tiles and see if owner is same for all
    public bool AllOwned()
    {
        if (this.GetOwner() == null) return false;
        foreach (GameObject o in linkedTiles)
        {
            if (o.GetComponent<TileScript>().GetOwner() != this.GetOwner())
                return false;
        }
        return true;
    }

    // returns reference to owner's GameObject
    public GameObject GetOwner()
    {
        return owner;
    }

    // get the buy cost of the tile. If not buyable, should be set to zero.
    public int GetBuyCost()
    {
        return buyCost;
    }
}
