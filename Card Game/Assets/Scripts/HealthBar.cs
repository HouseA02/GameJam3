using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    private TMP_Text valueText;
    private int maxHP;
    public Player player;
    
    void Update()
    {
        slider.maxValue = player.maxHP;
        slider.value = player.currentHP;
        valueText.text = player.currentHP + "/" + player.maxHP;
    }
}
