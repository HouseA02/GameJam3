using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int currentHP;
    public int currentMana;
    public int maxHP;
    public int maxMana;
    public int block;
    private int newDamage;

    public HealthBar healthBar;
    public Mana mana;
    public Card card;

    void Start()
    {
        maxHP = 50;
        maxMana = 3;
        currentHP = maxHP;
        currentMana = maxMana;
    }

    public void reset()
    {
        currentMana = maxMana;
        block = 0;
    }

    public void Hurt(int damage)
    {
        newDamage = damage - block;
        block -= damage;
        if(newDamage < 0)
        {
            newDamage = 0;
        }
        currentHP -= newDamage;
    }

    public void GainBlock(int plusBlock)
    {
        block += plusBlock;
    }

    public void SpendMana(int manaCost)
    {
        currentMana -= manaCost;
    }
    void Update()
    {
        if (block < 0)
        {
            block = 0;
        }
    }
}
