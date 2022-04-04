using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shield : MonoBehaviour

{
    [SerializeField]
    private TMP_Text BlockText;
    [SerializeField]
    private GameObject shield;
    public Player player;

    void Update()
    {
        BlockText.text = player.block.ToString();
        if (player.block > 0)
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }
    }
}

