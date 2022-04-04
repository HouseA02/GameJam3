using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyShield : MonoBehaviour

{
    [SerializeField]
    private TMP_Text EnemyBlockText;
    [SerializeField]
    private GameObject shield;
    public Enemy enemy;

    void Update()
    {
        EnemyBlockText.text = enemy.block.ToString();
        if (enemy.block > 0)
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }
    }
}
