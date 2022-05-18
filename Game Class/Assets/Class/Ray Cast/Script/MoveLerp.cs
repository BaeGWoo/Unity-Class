using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public GameObject point;
    public float speed;

   

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp
            (
            transform.position,//A위치
            point.transform.position,//B위치
            speed * Time.deltaTime
            );
    }
}
