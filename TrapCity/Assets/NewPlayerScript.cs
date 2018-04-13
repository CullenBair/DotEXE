using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

public class NewPlayerScript : MonoBehaviour {

    public string playerName;
    private GameManagerScript gm;

    // Use this for initialization
    void Start () {
        gm = GameManagerScript.instance();
	}

    void newUser()
    {
        playerName = GetComponent<InputField>().text;
        gm.socket.Emit("new user", JsonConvert.SerializeObject(playerName)); // JsonConvert.SerializeObject(gm.FirstPlayer)
    }
	
	// Update is called once per frame
	void Update () {
        
        
    }


    
}
