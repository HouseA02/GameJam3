using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    private TMP_Text valueText;
    private int maxHP;
    public Enemy enemy;


    void Update()
    {
        slider.maxValue = enemy.maxHP;
        slider.value = enemy.currentHP;
        valueText.text = enemy.currentHP + "/" + enemy.maxHP;
    }
}
