using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Patton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    public bool check;
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
            check = true;
        }
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (movecheck == false)
        {
            check = false;
        }
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        if (movecheck!)
        {
            check = false;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        check = false;
        movecheck = false;
        upcheck = true;
    }

    private void Update()
    {
        if (check)
        {
            image.color = Color.green;
        }
        if (upcheck)
        {
            image.color = Color.black;
        }
    }
}
