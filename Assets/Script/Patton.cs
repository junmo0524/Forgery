using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Patton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    public bool check;
    public int Num;
    public static int Score;
    public static bool movecheck;
    public static bool upcheck;
    public GameObject patton;
    Image image;

    public void Start()
    {
        image = patton.GetComponent<Image>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        check = true;
        movecheck = true;
        upcheck = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (movecheck)
        {
            if (check == false)
            {
                check = true;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (movecheck)
        {
            check = false;
        }
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (movecheck == false)
        {
            check = false;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        check = false;
        movecheck = false;
        upcheck = true;
        Score = 0;
    }

    public void Update()
    {
        if (check)
        {
            image.color = Color.green;
            Score = Num;
        }
        if (upcheck)
        {
            image.color = Color.black;
        }
        if (Input.GetMouseButtonUp(0))
        {
            check = false;
            Score = 0;
        }
    }
}
