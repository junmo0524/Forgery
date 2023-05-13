using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Lock : MonoBehaviour
{
    List<int> datas = new List<int>();
    List<int> keys = new List<int>() {1,2,3};

    void Update()
    {
        int currentScore = Patton.Score;

        if (datas.Count == 0 || currentScore != datas[datas.Count - 1])
        {
            datas.Add(currentScore);
            Debug.Log("Score added: " + currentScore);
        }
        bool result = Enumerable.SequenceEqual(datas, keys);
        Debug.Log(result);
        //PrintList();
    }
    /*void PrintList()
    {
        Debug.Log("리스트에 저장된 값:");
        foreach (int value in datas)
        {
            Debug.Log(value);
        }
    }*/
}
