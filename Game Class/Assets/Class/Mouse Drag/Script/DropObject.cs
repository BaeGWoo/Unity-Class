using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DropObject : MonoBehaviour
{
    private Vector3 offset;

    private float coordZ;


    public void OnMouseDown()
    {
        coordZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        offset = gameObject.transform.position = GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = coordZ;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + offset;
    }
}
