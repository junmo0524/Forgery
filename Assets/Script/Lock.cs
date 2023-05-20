using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class Lock : MonoBehaviour
{
    List<int> datas = new List<int>();
    List<int> keys = new List<int>() { 0, 1, 2, 3 };

    void Update()
    {
        int currentScore = Patton.Score;

        if (datas.Count == 0 || currentScore != datas[datas.Count - 1])
        {
            if (!datas.Contains(currentScore))
            {
                datas.Add(currentScore);
                Debug.Log("Score added: " + currentScore);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            bool result = Enumerable.SequenceEqual(datas, keys);
            Debug.Log(result);
            datas.Clear();
        }
    }
}

