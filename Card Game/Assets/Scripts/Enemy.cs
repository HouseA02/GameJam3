using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public EnemyDetails enemyDetails;
    public int currentHP;
    public int maxHP;
    private int newDamage;
    public int block;
    public int blockStat;
    public int attack;
    public int intent;

    public Player player;
    public TMP_Text intentText;
    public SpriteRenderer spriteRenderer;
    public EnemyHealthBar enemyHealthBar;

    void Start()
    {
        attack = enemyDetails.enemyAttack;
        blockStat = enemyDetails.enemyBlock;
        spriteRenderer.sprite = enemyDetails.enemyArt;
        maxHP = enemyDetails.enemyHP;
        currentHP = maxHP;
        RandIntent();
    }

    public void Hurt(int damage)
    {
        newDamage = damage - block;
        block -= damage;
        currentHP -= newDamage;
    }

    public void GainBlock(int plusBlock)
    {
        block += plusBlock;
    }

    public void RandIntent()
    {
        attack = Random.Range((attack-2),(attack+2));
        blockStat = Random.Range((blockStat-1),(blockStat+1));
        intent = Random.Range(1,3);
        if (intent == 1)
        {
            intentText.text = "Incoming - Attack :" + attack;
        }if (intent == 2)
        {
            intentText.text = "Incoming - Block :" +  blockStat;
        }
        attack = enemyDetails.enemyAttack;
        blockStat = enemyDetails.enemyBlock;
    }

    public void Action()
    {
        if (intent == 1)
        {
            player.Hurt(attack);
        }
        if (intent == 2)
        {
            GainBlock(blockStat);
        }
    }

    void Update()
    {
        if (block < 0)
        {
            block = 0;
        }

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}


    