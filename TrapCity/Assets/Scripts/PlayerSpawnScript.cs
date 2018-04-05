using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnScript : MonoBehaviour {

    public GameManagerScript gm;
    public GameObject player;      // Object to spawn
    public Sprite[] avatarSprites; // Array of avatar images

	// NOTE: Dependency on game manager's numOfPlayers being accurate
	void Start ()
    {
        // Get Number of players
        int numPlayers = gm.GetNumPlayers();
        GameObject temp;

        // Create Avatars
        for (int i = 0; i < numPlayers; i++)
        {
            // Instantiate players and assign an avatar, place at GO
            temp = Instantiate(player);
            temp.GetComponent<SpriteRenderer>().sprite = avatarSprites[i % avatarSprites.Length];
            temp.GetComponent<Transform>().SetPositionAndRotation(transform.position, new Quaternion(0,0,0,0)); 

            // Place in GM's player array?
        }
	}
}
