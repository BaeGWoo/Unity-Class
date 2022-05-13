using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
            transform.position,//현재 자기 위치
            target.transform.position,//목표 게임 오브젝트 위치
            speed * Time.deltaTime//현재 위치에서 목표위치로 이동할 속도
            );
    }
}
