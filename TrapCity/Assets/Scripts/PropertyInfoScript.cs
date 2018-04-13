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
                case 11:
                    Property11();
                    break;
                case 12:
                    Property12();
                    break;
                case 13:
                    Property13();
                    break;
                case 14:
                    Property14();
                    break;
                case 15:
                    Property15();
                    break;
                case 16:
                    Property16();
                    break;
                case 17:
                    Property17();
                    break;
                case 18:
                    Property18();
                    break;
                case 19:
                    Property19();
                    break;
                case 20:
                    Property20();
                    break;
                case 21:
                    Property21();
                    break;
                case 22:
                    Property22();
                    break;
                case 23:
                    Property23();
                    break;
                case 24:
                    Property24();
                    break;
                case 25:
                    Property25();
                    break;
                case 26:
                    Property26();
                    break;
                case 27:
                    Property27();
                    break;
                case 28:
                    Property28();
                    break;
                case 29:
                    Property29();
                    break;
                case 30:
                    Property30();
                    break;
                case 31:
                    Property31();
                    break;
                case 32:
                    Property32();
                    break;
                case 33:
                    Property33();
                    break;
                case 34:
                    Property34();
                    break;
                case 35:
                    Property35();
                    break;
                case 36:
                    Property36();
                    break;
                case 37:
                    Property37();
                    break;
                case 38:
                    Property38();
                    break;
                case 39:
                    Property39();
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
        GetComponent<Text>().text += "Cost: $60\n\n";
        GetComponent<Text>().text += "Base Rent: $2\n";
        GetComponent<Text>().text += " With 1 house: $10\n";
        GetComponent<Text>().text += " With 2 houses: $30\n";
        GetComponent<Text>().text += " With 3 houses: $90\n";
        GetComponent<Text>().text += " With 4 houses: $160\n";
        GetComponent<Text>().text += " With hotel: $250\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $30\n";
    }

    void Property2()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property3()
    {
        GetComponent<Text>().text = "Baltic Avenue\n";
        GetComponent<Text>().text += "Cost: $60\n\n";
        GetComponent<Text>().text += "Base Rent: $4\n";
        GetComponent<Text>().text += " With 1 house: $20\n";
        GetComponent<Text>().text += " With 2 houses: $60\n";
        GetComponent<Text>().text += " With 3 houses: $180\n";
        GetComponent<Text>().text += " With 4 houses: $320\n";
        GetComponent<Text>().text += " With hotel: $450\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $30\n";
    }

    void Property4()
    {
        GetComponent<Text>().text = "Income Tax\n\n";
        GetComponent<Text>().text += "Pay 10% or $200\n";
    }

    void Property5()
    {
        GetComponent<Text>().text = "Reading Railroad\n";
        GetComponent<Text>().text += "Cost: $200\n\n";
        GetComponent<Text>().text += "Base Rent: $25\n";
        GetComponent<Text>().text += " If 2 Railroads are owned: $50\n";
        GetComponent<Text>().text += " If 3 Railroads are owned: $100\n";
        GetComponent<Text>().text += " If 4 Railroads are owned: $200\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property6()
    {
        GetComponent<Text>().text = "Oriental Avenue\n";
        GetComponent<Text>().text += "Cost: $100\n\n";
        GetComponent<Text>().text += "Base Rent: $6\n";
        GetComponent<Text>().text += " With 1 house: $30\n";
        GetComponent<Text>().text += " With 2 houses: $90\n";
        GetComponent<Text>().text += " With 3 houses: $270\n";
        GetComponent<Text>().text += " With 4 houses: $400\n";
        GetComponent<Text>().text += " With hotel: $550\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
    }

    void Property7()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property8()
    {
        GetComponent<Text>().text = "Vermont Avenue\n";
        GetComponent<Text>().text += "Cost: $100\n\n";
        GetComponent<Text>().text += "Base Rent: $6\n";
        GetComponent<Text>().text += " With 1 house: $30\n";
        GetComponent<Text>().text += " With 2 houses: $90\n";
        GetComponent<Text>().text += " With 3 houses: $270\n";
        GetComponent<Text>().text += " With 4 houses: $400\n";
        GetComponent<Text>().text += " With hotel: $550\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
    }

    void Property9()
    {
        GetComponent<Text>().text = "Connecticut Avenue\n";
        GetComponent<Text>().text += "Cost: $120\n\n";
        GetComponent<Text>().text += "Base Rent: $8\n";
        GetComponent<Text>().text += " With 1 house: $40\n";
        GetComponent<Text>().text += " With 2 houses: $100\n";
        GetComponent<Text>().text += " With 3 houses: $300\n";
        GetComponent<Text>().text += " With 4 houses: $450\n";
        GetComponent<Text>().text += " With hotel: $600\n";
        GetComponent<Text>().text += "Houses cost $50 each\n";
        GetComponent<Text>().text += "Hotels cost $50 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $50\n";
    }

    void Property10()
    {
        GetComponent<Text>().text = "Jail\n\n";
        GetComponent<Text>().text += "Just Visiting\n";
    }

    void Property11()
    {
        GetComponent<Text>().text = "St. Charles Place\n";
        GetComponent<Text>().text += "Cost: $140\n\n";
        GetComponent<Text>().text += "Base Rent: $10\n";
        GetComponent<Text>().text += " With 1 house: $50\n";
        GetComponent<Text>().text += " With 2 houses: $150\n";
        GetComponent<Text>().text += " With 3 houses: $450\n";
        GetComponent<Text>().text += " With 4 houses: $625\n";
        GetComponent<Text>().text += " With hotel: $750\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $70\n";
    }

    void Property12()
    {
        GetComponent<Text>().text = "Electric Company\n";
        GetComponent<Text>().text += "Cost: $150\n\n";
        GetComponent<Text>().text += "If one 'Utility' is owned, rent is 4 times the amount shown on dice\n";
        GetComponent<Text>().text += "If both 'Utilities' are owned, rent is 10 times the amount shown on dice\n";
        GetComponent<Text>().text += "Mortage Value: $75\n";
    }

    void Property13()
    {
        GetComponent<Text>().text = "States Avenue\n";
        GetComponent<Text>().text += "Cost: $150\n\n";
        GetComponent<Text>().text += "Base Rent: $10\n";
        GetComponent<Text>().text += " With 1 house: $50\n";
        GetComponent<Text>().text += " With 2 houses: $150\n";
        GetComponent<Text>().text += " With 3 houses: $450\n";
        GetComponent<Text>().text += " With 4 houses: $625\n";
        GetComponent<Text>().text += " With hotel: $750\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $70\n";
    }

    void Property14()
    {
        GetComponent<Text>().text = "Virginia Avenue\n";
        GetComponent<Text>().text += "Cost: $160\n\n";
        GetComponent<Text>().text += "Base Rent: $12\n";
        GetComponent<Text>().text += " With 1 house: $60\n";
        GetComponent<Text>().text += " With 2 houses: $180\n";
        GetComponent<Text>().text += " With 3 houses: $500\n";
        GetComponent<Text>().text += " With 4 houses: $700\n";
        GetComponent<Text>().text += " With hotel: $900\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $80\n";
    }

    void Property15()
    {
        GetComponent<Text>().text = "Pennsylvania Railroad\n";
        GetComponent<Text>().text += "Cost: $200\n\n";
        GetComponent<Text>().text += "Base Rent: $25\n";
        GetComponent<Text>().text += " If 2 Railroads are owned: $50\n";
        GetComponent<Text>().text += " If 3 Railroads are owned: $100\n";
        GetComponent<Text>().text += " If 4 Railroads are owned: $200\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property16()
    {
        GetComponent<Text>().text = "St. James Place\n";
        GetComponent<Text>().text += "Cost: $180\n\n";
        GetComponent<Text>().text += "Base Rent: $14\n";
        GetComponent<Text>().text += " With 1 house: $70\n";
        GetComponent<Text>().text += " With 2 houses: $200\n";
        GetComponent<Text>().text += " With 3 houses: $550\n";
        GetComponent<Text>().text += " With 4 houses: $750\n";
        GetComponent<Text>().text += " With hotel: $950\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $90\n";
    }

    void Property17()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property18()
    {
        GetComponent<Text>().text = "Tennessee Avenue\n";
        GetComponent<Text>().text += "Cost: $180\n\n";
        GetComponent<Text>().text += "Base Rent: $14\n";
        GetComponent<Text>().text += " With 1 house: $70\n";
        GetComponent<Text>().text += " With 2 houses: $200\n";
        GetComponent<Text>().text += " With 3 houses: $550\n";
        GetComponent<Text>().text += " With 4 houses: $750\n";
        GetComponent<Text>().text += " With hotel: $950\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $90\n";
    }

    void Property19()
    {
        GetComponent<Text>().text = "New York Avenue\n";
        GetComponent<Text>().text += "Cost: $200\n\n";
        GetComponent<Text>().text += "Base Rent: $16\n";
        GetComponent<Text>().text += " With 1 house: $80\n";
        GetComponent<Text>().text += " With 2 houses: $220\n";
        GetComponent<Text>().text += " With 3 houses: $600\n";
        GetComponent<Text>().text += " With 4 houses: $800\n";
        GetComponent<Text>().text += " With hotel: $1000\n";
        GetComponent<Text>().text += "Houses cost $100 each\n";
        GetComponent<Text>().text += "Hotels cost $100 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property20()
    {
        GetComponent<Text>().text = "Free Parking\n\n";
        GetComponent<Text>().text += "Do nothing\n";
    }

    void Property21()
    {
        GetComponent<Text>().text = "Kentucky Avenue\n";
        GetComponent<Text>().text += "Cost: $220\n\n";
        GetComponent<Text>().text += "Base Rent: $18\n";
        GetComponent<Text>().text += " With 1 house: $90\n";
        GetComponent<Text>().text += " With 2 houses: $250\n";
        GetComponent<Text>().text += " With 3 houses: $700\n";
        GetComponent<Text>().text += " With 4 houses: $875\n";
        GetComponent<Text>().text += " With hotel: $1050\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $110\n";
    }

    void Property22()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property23()
    {
        GetComponent<Text>().text = "Indiana Avenue\n";
        GetComponent<Text>().text += "Cost: $220\n\n";
        GetComponent<Text>().text += "Base Rent: $18\n";
        GetComponent<Text>().text += " With 1 house: $90\n";
        GetComponent<Text>().text += " With 2 houses: $250\n";
        GetComponent<Text>().text += " With 3 houses: $700\n";
        GetComponent<Text>().text += " With 4 houses: $875\n";
        GetComponent<Text>().text += " With hotel: $1050\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $110\n";
    }

    void Property24()
    {
        GetComponent<Text>().text = "Illinois Avenue\n";
        GetComponent<Text>().text += "Cost: $240\n\n";
        GetComponent<Text>().text += "Base Rent: $20\n";
        GetComponent<Text>().text += " With 1 house: $100\n";
        GetComponent<Text>().text += " With 2 houses: $300\n";
        GetComponent<Text>().text += " With 3 houses: $750\n";
        GetComponent<Text>().text += " With 4 houses: $925\n";
        GetComponent<Text>().text += " With hotel: $1100\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $120\n";
    }

    void Property25()
    {
        GetComponent<Text>().text = "B. & O. Railroad\n";
        GetComponent<Text>().text += "Cost: $200\n\n";
        GetComponent<Text>().text += "Base Rent: $25\n";
        GetComponent<Text>().text += " If 2 Railroads are owned: $50\n";
        GetComponent<Text>().text += " If 3 Railroads are owned: $100\n";
        GetComponent<Text>().text += " If 4 Railroads are owned: $200\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property26()
    {
        GetComponent<Text>().text = "Atlantic Avenue\n";
        GetComponent<Text>().text += "Cost: $260\n\n";
        GetComponent<Text>().text += "Base Rent: $22\n";
        GetComponent<Text>().text += " With 1 house: $110\n";
        GetComponent<Text>().text += " With 2 houses: $330\n";
        GetComponent<Text>().text += " With 3 houses: $800\n";
        GetComponent<Text>().text += " With 4 houses: $975\n";
        GetComponent<Text>().text += " With hotel: $1150\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $130\n";
    }

    void Property27()
    {
        GetComponent<Text>().text = "Ventnor Avenue\n";
        GetComponent<Text>().text += "Cost: $260\n\n";
        GetComponent<Text>().text += "Base Rent: $22\n";
        GetComponent<Text>().text += " With 1 house: $110\n";
        GetComponent<Text>().text += " With 2 houses: $330\n";
        GetComponent<Text>().text += " With 3 houses: $800\n";
        GetComponent<Text>().text += " With 4 houses: $975\n";
        GetComponent<Text>().text += " With hotel: $1150\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $130\n";
    }

    void Property28()
    {
        GetComponent<Text>().text = "Water Works\n";
        GetComponent<Text>().text += "Cost: $150\n\n";
        GetComponent<Text>().text += "If one 'Utility' is owned, rent is 4 times the amount shown on dice\n";
        GetComponent<Text>().text += "If both 'Utilities' are owned, rent is 10 times the amount shown on dice\n";
        GetComponent<Text>().text += "Mortage Value: $75\n";
    }

    void Property29()
    {
        GetComponent<Text>().text = "Marvin Gardens\n";
        GetComponent<Text>().text += "Cost: $280\n\n";
        GetComponent<Text>().text += "Base Rent: $24\n";
        GetComponent<Text>().text += " With 1 house: $120\n";
        GetComponent<Text>().text += " With 2 houses: $360\n";
        GetComponent<Text>().text += " With 3 houses: $850\n";
        GetComponent<Text>().text += " With 4 houses: $1025\n";
        GetComponent<Text>().text += " With hotel: $1200\n";
        GetComponent<Text>().text += "Houses cost $150 each\n";
        GetComponent<Text>().text += "Hotels cost $150 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $140\n";
    }

    void Property30()
    {
        GetComponent<Text>().text = "Go To Jail\n\n";
        GetComponent<Text>().text += "Straight to jail, do not pass Go\n";
    }

    void Property31()
    {
        GetComponent<Text>().text = "Pacific Avenue\n";
        GetComponent<Text>().text += "Cost: $300\n\n";
        GetComponent<Text>().text += "Base Rent: $26\n";
        GetComponent<Text>().text += " With 1 house: $130\n";
        GetComponent<Text>().text += " With 2 houses: $390\n";
        GetComponent<Text>().text += " With 3 houses: $900\n";
        GetComponent<Text>().text += " With 4 houses: $1100\n";
        GetComponent<Text>().text += " With hotel: $1275\n";
        GetComponent<Text>().text += "Houses cost $200 each\n";
        GetComponent<Text>().text += "Hotels cost $200 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $150\n";
    }

    void Property32()
    {
        GetComponent<Text>().text = "North Carolina Avenue\n";
        GetComponent<Text>().text += "Cost: $300\n\n";
        GetComponent<Text>().text += "Base Rent: $26\n";
        GetComponent<Text>().text += " With 1 house: $130\n";
        GetComponent<Text>().text += " With 2 houses: $390\n";
        GetComponent<Text>().text += " With 3 houses: $900\n";
        GetComponent<Text>().text += " With 4 houses: $1100\n";
        GetComponent<Text>().text += " With hotel: $1275\n";
        GetComponent<Text>().text += "Houses cost $200 each\n";
        GetComponent<Text>().text += "Hotels cost $200 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $150\n";
    }

    void Property33()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property34()
    {
        GetComponent<Text>().text = "Pennsylvania Avenue\n";
        GetComponent<Text>().text += "Cost: $320\n\n";
        GetComponent<Text>().text += "Base Rent: $28\n";
        GetComponent<Text>().text += " With 1 house: $150\n";
        GetComponent<Text>().text += " With 2 houses: $450\n";
        GetComponent<Text>().text += " With 3 houses: $1000\n";
        GetComponent<Text>().text += " With 4 houses: $1200\n";
        GetComponent<Text>().text += " With hotel: $1400\n";
        GetComponent<Text>().text += "Houses cost $200 each\n";
        GetComponent<Text>().text += "Hotels cost $200 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $160\n";
    }

    void Property35()
    {
        GetComponent<Text>().text = "Short Line\n";
        GetComponent<Text>().text += "Cost: $200\n\n";
        GetComponent<Text>().text += "Base Rent: $25\n";
        GetComponent<Text>().text += " If 2 Railroads are owned: $50\n";
        GetComponent<Text>().text += " If 3 Railroads are owned: $100\n";
        GetComponent<Text>().text += " If 4 Railroads are owned: $200\n";
        GetComponent<Text>().text += "Mortgage Value: $100\n";
    }

    void Property36()
    {
        GetComponent<Text>().text = "Draw a card\n\n";
        GetComponent<Text>().text += "Follow directions on card\n";
    }

    void Property37()
    {
        GetComponent<Text>().text = "Park Place\n";
        GetComponent<Text>().text += "Cost: $350\n\n";
        GetComponent<Text>().text += "Base Rent: $35\n";
        GetComponent<Text>().text += " With 1 house: $175\n";
        GetComponent<Text>().text += " With 2 houses: $500\n";
        GetComponent<Text>().text += " With 3 houses: $1100\n";
        GetComponent<Text>().text += " With 4 houses: $1300\n";
        GetComponent<Text>().text += " With hotel: $1500\n";
        GetComponent<Text>().text += "Houses cost $200 each\n";
        GetComponent<Text>().text += "Hotels cost $200 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $175\n";
    }

    void Property38()
    {
        GetComponent<Text>().text = "Luxury Tax\n\n";
        GetComponent<Text>().text += "Pay $75\n";
    }

    void Property39()
    {
        GetComponent<Text>().text = "Boardwalk\n";
        GetComponent<Text>().text += "Cost: $400\n\n";
        GetComponent<Text>().text += "Base Rent: $50\n";
        GetComponent<Text>().text += " With 1 house: $200\n";
        GetComponent<Text>().text += " With 2 houses: $600\n";
        GetComponent<Text>().text += " With 3 houses: $1400\n";
        GetComponent<Text>().text += " With 4 houses: $1700\n";
        GetComponent<Text>().text += " With hotel: $2000\n";
        GetComponent<Text>().text += "Houses cost $200 each\n";
        GetComponent<Text>().text += "Hotels cost $200 plus 4 houses\n";
        GetComponent<Text>().text += "Mortgage Value: $200\n";
    }
}
