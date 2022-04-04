using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardDetails cardDetails;
    public TMP_Text cardName;
    public TMP_Text cardText;
    public TMP_Text manaCost;
    public Image cardArt;

    // Start is called before the first frame update
    void Start()
    {
        cardName.text = cardDetails.cardName;
        cardText.text = cardDetails.cardText;
        manaCost.text = cardDetails.manaCost.ToString();
        cardArt.sprite = cardDetails.cardArt;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
