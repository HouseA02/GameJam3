using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardDetails : ScriptableObject
{
    public string cardName;
    public string cardText;
    public int manaCost;
    public Sprite cardArt;
    public int damage;
    public int draw;
    public int block;
    public int burn;

    void Update()
    {
        
    }
}

