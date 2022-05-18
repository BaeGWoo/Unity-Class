using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piicking : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //충돌정보를 나타나게 해주는 것
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit))
            {
                Debug.Log(hit.distance);
                //ray의 원점 , 충돌물체의 위치 , 색상
                Debug.DrawLine(ray.origin, hit.point, Color.red);
            }
        }
    }
}
