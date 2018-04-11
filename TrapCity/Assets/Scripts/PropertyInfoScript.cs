using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PropertyInfoScript : MonoBehaviour {

    //public int propertyIndex;
    public int isUp;

	// Use this for initialization
	void Start () {
        //propertyIndex = Convert.ToInt32(this.name);
        isUp = -1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WhichProperty(int prop)
    {
        if (isUp != prop)
        {
           // int index = propertyIndex;
            switch (prop)
            {
                case 0:
                    Property0();
                    break;
                case 1:
                    Property1();
                    break;
                case 2:
                    Property2();
                    break;
                case 3:
                    Property3();
                    break;
                case 4:
                    Property4();
                    break;
                case 5:
                    Property5();
                    break;
                case 6:
                    Property6();
                    break;
                case 7:
                    Property7();
                    break;
                case 8:
                    Property8();
                    break;
                case 9:
                    Property9();
                    break;
                case 10:
                    Property10();
                    break;
                default:
                    break;
            }
            isUp = prop;
        }
        else
        {
            GetComponent<Text>().text = "";
            isUp = -1;
        }

    }

    void Property0()
    {
        GetComponent<Text>().text = "GO\n\n";
        GetComponent<Text>().text += "Collect $200 as you pass\n";
    }

    void Property1()
    {
        GetComponent<Text>().text = "Mediterranean Avenue\n";
        GetComponent<Text>().text += "Base Rent: $2\n";
        GetComponent<Text>().text += " With 1 house: $10\n";
        GetComponent<Text>().text += " With 2 houses: $30\n";
        GetComponent<Text>().text += " With 3 houses: $90\n";
        GetComponent<Text>().text += " With 4 houses: $160\n";
        GetComponent<Text>().text += " With hotel: $250\n";
        GetComponent<Text>().text += "Mortgage Value: $30\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
    }

    void Property2()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property3()
    {
        GetComponent<Text>().text = "Baltic Avenue\n";
        GetComponent<Text>().text += "Base Rent: $4\n";
        GetComponent<Text>().text += " With 1 house: $20\n";
        GetComponent<Text>().text += " With 2 houses: $60\n";
        GetComponent<Text>().text += " With 3 houses: $180\n";
        GetComponent<Text>().text += " With 4 houses: $320\n";
        GetComponent<Text>().text += " With hotel: $450\n";
        GetComponent<Text>().text += "Mortgage Value: $30\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
    }

    void Property4()
    {
        GetComponent<Text>().text = "Income Tax\n\n";
        GetComponent<Text>().text += "Pay 10% or $200\n";
    }

    void Property5()
    {
        GetComponent<Text>().text = "Reading Railroad\n";
        GetComponent<Text>().text += "Base Rent: $25\n";
        GetComponent<Text>().text += " If 2 Railroads are owned: $50\n";
        GetComponent<Text>().text += " If 3 Railroads are owned: $100\n";
        GetComponent<Text>().text += " If 4 Railroads are owned: $200\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property6()
    {
        GetComponent<Text>().text = "Oriental Avenue\n";
        GetComponent<Text>().text += "Base Rent: $6\n";
        GetComponent<Text>().text += " With 1 house: $30\n";
        GetComponent<Text>().text += " With 2 houses: $90\n";
        GetComponent<Text>().text += " With 3 houses: $270\n";
        GetComponent<Text>().text += " With 4 houses: $400\n";
        GetComponent<Text>().text += " With hotel: $550\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
    }

    void Property7()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property8()
    {
        GetComponent<Text>().text = "Vermont Avenue\n";
        GetComponent<Text>().text += "Base Rent: $6\n";
        GetComponent<Text>().text += " With 1 house: $30\n";
        GetComponent<Text>().text += " With 2 houses: $90\n";
        GetComponent<Text>().text += " With 3 houses: $270\n";
        GetComponent<Text>().text += " With 4 houses: $400\n";
        GetComponent<Text>().text += " With hotel: $550\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
    }

    void Property9()
    {
        GetComponent<Text>().text = "Connecticut Avenue\n";
        GetComponent<Text>().text += "Base Rent: $8\n";
        GetComponent<Text>().text += " With 1 house: $40\n";
        GetComponent<Text>().text += " With 2 houses: $100\n";
        GetComponent<Text>().text += " With 3 houses: $300\n";
        GetComponent<Text>().text += " With 4 houses: $450\n";
        GetComponent<Text>().text += " With hotel: $600\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
    }

    void Property10()
    {
        GetComponent<Text>().text = "Jail\n\n";
        GetComponent<Text>().text += "Just Visiting\n";
    }
}
