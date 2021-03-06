﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance { get; private set; }
    public Text scoreText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "0";
    }

    public void SetValue(int score)
    {
        scoreText.text = score.ToString();
    }
}

