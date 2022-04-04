using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnController : MonoBehaviour
{
    private bool yourTurn = true;

    public bool YourTurn { get => yourTurn; set => yourTurn = value; }
    //[SerializeField]
    //private int counter = 1000;

    //public int Counter { get => counter; set => counter = value; }
    [SerializeField]

    public TMP_Text drawText;
    public TMP_Text discardText;
    public List<Card> drawPile = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public List<Card> hand = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableSlot;
    [SerializeField]
    private Switch Switch;

    public void Draw(int draw)
    {
        for(int i = 0; i < draw; i++)
        {
            if (drawPile.Count < 1)
            {
                Shuffle();
            }
            else
            {
                
            }
            DrawOne();
        }
    }

    public void DrawOne()
    {
        if (drawPile.Count >= 1)
        {
            Card randCard = drawPile[Random.Range(0, drawPile.Count)];
            for (int j = 0; j < availableSlot.Length; j++)
            {
                if (availableSlot[j] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.handNumber = j;
                    hand.Add(randCard);
                    randCard.played = false;
                    randCard.transform.position = cardSlots[j].position;
                    availableSlot[j] = false;
                    drawPile.Remove(randCard);
                    return;
                }
            }
        }
    }

    public void Shuffle()
    {
        foreach(Card card in discardPile)
        {
            drawPile.Add(card);
        }
        discardPile.Clear();
    }

    public void DiscardHand()
    {
        for (int k = 0; k < 4; k++)
        {
            availableSlot[k] = true;
        }
        foreach (Card card in hand)
        {
            discardPile.Add(card);
            card.gameObject.SetActive(false);
        }
        hand.Clear();
    }

    void Start()
    {
        Draw(3);
    }

    
    void Update()
    {
        drawText.text = drawPile.Count.ToString();
        discardText.text = discardPile.Count.ToString();
        /*counter--;
        if (counter == 0)
        {
            Switch.SetSwtiched(true);
            counter = 1000;
        }*/
            
    }
}
