﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BombSpriteChange.gameWin == false)
        {
            timer += Time.deltaTime;
            timerText.text = "Timer: " + Mathf.Clamp(12f - Mathf.Round(timer * 100f) / 100f, 0f, 10f);
        }
        

        if (timer >= 2f && BombSpriteChange.gameBegin == false)
        {
            BombSpriteChange.gameBegin = true;
        }

        if (timer >= 13f && BombSpriteChange.gameLoss == false)
        {
            BombSpriteChange.gameLoss = true;
        }
    }
}
