using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        // A new card is added to the card list.
        cardList.Add(new Card(0, "Fireball 1", 0, 1, "Fireball 1"));
        cardList.Add(new Card(1, "Fireball 2", 2, 2, "The second fireball."));
        cardList.Add(new Card(2, "Fireball 3", 1, 3, "The third fireball."));
        cardList.Add(new Card(3, "Fireball 4", 1, 4, "The fourth fireball."));
        cardList.Add(new Card(4, "Poison", 3, 5, "A bottle of poison."));
                            // Freshmen picks.
        cardList.Add(new Card(5, "Electric", 4, 0, "Gives a natural power."));
        cardList.Add(new Card(6, "Spears", 6, 10, "Gives player 10 damage "));
        cardList.Add(new Card(7, "Fist Punch", 8, 20, "A fist of ultimate power "));
        cardList.Add(new Card(8, "Purple shade", 15, 30, "purple aura sheild"));
    }

}
