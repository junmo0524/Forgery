using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Lock : MonoBehaviour
{
    List<int> datas = new List<int>();

    void Update()
    {
        int currentScore = Patton.Score;

        if (datas.Count == 0 || currentScore != datas[datas.Count - 1])
        {
            datas.Add(currentScore);
            Debug.Log("Score added: " + currentScore);
        }
    }
}
