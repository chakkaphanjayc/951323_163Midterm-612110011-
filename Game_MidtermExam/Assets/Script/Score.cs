﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreText.text = GameApplicationManager.Instance.Score;
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score  " + (int)(GameApplicationManager.Instance.Score);
    }
}
