using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyDetails : ScriptableObject
{
    public string enemyName;
    public int enemyAttack;
    public Sprite enemyArt;
    public int enemyBlock;
    public int enemyHP;

    void Update()
    {

    }
}
