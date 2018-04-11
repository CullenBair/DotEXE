using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnPlayerInfo : MonoBehaviour {



	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "init";
	}
	
	// Update is called once per frame
	void Update () {
        if(GetComponent<PropertyInfoScript>().isUp == -1)
        {
            GetComponent<Text>().text = "Player informationnnnnnnnnn";
        }
	}
}
