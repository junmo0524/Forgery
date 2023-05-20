using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Line : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public LineRenderer lineRenderer;
    private bool isDragging = false;
    private Vector3 startPoint;
    private Vector3 middlePoint;
    private Vector3 middlePoint1;
    private Vector3 middlePoint2;
    private Vector3 middlePoint3;
    private Vector3 middlePoint4;
    private Vector3 middlePoint5;
    private Vector3 middlePoint6;
    private Vector3 middlePoint7;
    private Vector3 endPoint;

    public void OnPointerDown(PointerEventData eventData)
    {
        startPoint = this.transform.position;
        isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            endPoint = eventData.pointerCurrentRaycast.worldPosition;

            Collider2D collider = Physics2D.OverlapPoint(endPoint);
            if (collider.tag == "1")
            {
                middlePoint = collider.transform.position;
            }
            if (collider.tag == "2")
            {
                middlePoint1 = collider.transform.position;
            }
            if (collider.tag == "3")
            {
                middlePoint2 = collider.transform.position;
            }
            if (collider.tag == "4")
            {
                middlePoint3 = collider.transform.position;
            }
            if (collider.tag == "5")
            {
                middlePoint4 = collider.transform.position;
            }
            if (collider.tag == "6")
            {
                middlePoint5 = collider.transform.position;
            }
            if (collider.tag == "7")
            {
                middlePoint6 = collider.transform.position;
            }
            if (collider.tag == "8")
            {
                middlePoint7 = collider.transform.position;
            }

            DrawLine();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    private void DrawLine()
    {
        lineRenderer.positionCount = 9;
        lineRenderer.SetPosition(0, startPoint);
        lineRenderer.SetPosition(1, middlePoint);
        lineRenderer.SetPosition(2, middlePoint1);
        lineRenderer.SetPosition(3, middlePoint2);
        lineRenderer.SetPosition(4, middlePoint3);
        lineRenderer.SetPosition(5, middlePoint4);
        lineRenderer.SetPosition(6, middlePoint5);
        lineRenderer.SetPosition(7, middlePoint6);
        lineRenderer.SetPosition(8, middlePoint7);
        lineRenderer.SetPosition(9, endPoint);
    }
}

