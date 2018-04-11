using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour {

    //public Color color;
    public bool highlighted;

	// Use this for initialization
	void Start () {
       // color = GetComponent<SpriteRenderer>().color;
    }
	
	// Update is called once per frame
	void Update () {
		if(!highlighted)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
	}

    public void ChangeColor()
    {
        //color = GetComponent<SpriteRenderer>().color;
        if (!highlighted)
        {
            GetComponent<ClearHighlighter>().clear();
            GetComponent<SpriteRenderer>().color = Color.magenta;
            highlighted = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            highlighted = false;
        }
    }
}
