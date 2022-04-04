using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mana : MonoBehaviour
{
    [SerializeField]
    private TMP_Text ManaText;
    private int maxMana;
    public Player player;

    void Update()
    {
        ManaText.text = player.currentMana + "/" + player.maxMana;
    }
}
