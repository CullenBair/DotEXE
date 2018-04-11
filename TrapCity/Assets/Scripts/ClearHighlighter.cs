using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearHighlighter : MonoBehaviour {

    public GameObject[] properties;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clear()
    {
        foreach(GameObject tile in properties)
        {
            tile.GetComponent<Highlighter>().highlighted = false;
        }
    }

}
