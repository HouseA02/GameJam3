using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField]
    public CardDetails cardDetails;
    public TMP_Text cardName;
    public TMP_Text cardText;
    public TMP_Text manaCost;
    public Image cardArt;

    public TurnController turnController;
    public Player player;
    public Enemy enemy;

    public bool played;
    [SerializeField]
    private bool inPlay = false;
    public int handNumber;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "PlayArea")
        {
            /*played = true;
            turnController.availableSlot[handNumber] = true;
            player.SpendMana(cardDetails.manaCost);
            enemy.Hurt(cardDetails.damage);
            turnController.Draw(cardDetails.draw);
            DiscardThis();*/
            inPlay = true;
            Debug.Log("Collision");
        }else
        {
            
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayArea")
        {
            Invoke("NotInPlay", 300);
            Debug.Log("Left Collision");
        }
        else
        {

        }
    }
    void NotInPlay()
    {
        inPlay = false;
    }


    public void Play()
    {
        if (inPlay == true  && player.currentMana >= cardDetails.manaCost)
        {
            played = true;
            turnController.availableSlot[handNumber] = true;
            player.SpendMana(cardDetails.manaCost);
            player.GainBlock(cardDetails.block);
            enemy.Hurt(cardDetails.damage);
            turnController.Draw(cardDetails.draw);
            DiscardThis();
        }
        else
        {
            transform.position = turnController.cardSlots[handNumber].position;
        }    
    }
    void DiscardThis()
    {
        turnController.discardPile.Add(this);
        turnController.hand.Remove(this);
        gameObject.SetActive(false);
    }
    void Start()
    {
        cardName.text = cardDetails.cardName;
        cardText.text = cardDetails.cardText;
        manaCost.text = cardDetails.manaCost.ToString();
        cardArt.sprite = cardDetails.cardArt;
        //
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {

    }

}
