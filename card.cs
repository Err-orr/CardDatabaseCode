using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    // identification for a card
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;



    public Card()
    {
        id = 0;
        cardName = "";
        cost = 0;
        power = 0;
        cardDescription = "";
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
    }

}
