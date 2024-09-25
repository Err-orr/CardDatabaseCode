using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    // Variables are created for a card.
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    // This is a default constructor. If you enter no arguements, then all of these variables for a new card will be set to default.
    public Card()
    {
        id = 0;
        cardName = "";
        cost = 0;
        power = 0;
        cardDescription = "";
    }
    /* 
    This is a parameter constructor. 
    There's 5 parameters that need to be entered in this constructor. 
    An int, string, int, int, and string which will go to respective variables to create a new card.
    */
    public Card(int Id, string CardName, int Cost, int Power, string CardDescription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
    }
}
