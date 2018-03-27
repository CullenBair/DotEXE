using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    // Make Singleton

    private static int NUM_OF_CARDS = 40;

    private GameObject[] deck;
    private GameObject[] players;
    int currentPlayer;

    private void Start()
    {
       // gets all "Card" objects in scene as an array
       deck = GameObject.FindGameObjectsWithTag("Card");
       players = GameObject.FindGameObjectsWithTag("Player");
       currentPlayer = FirstPlayer();
    }

    // Returns first player index, calculated randomly for now.
    public int FirstPlayer()
    {
        return 0;
    }

    // ----------------------- CardStuff ------------------------ //
    // Returns top card in deck
    public GameObject GetCard()
    {
        return null;
    }

    // To return card to bottom of deck
    public void AddCard(GameObject card)
    {
    }

    // Shuffle the deck
    private void Shuffle()
    {
    }

}
