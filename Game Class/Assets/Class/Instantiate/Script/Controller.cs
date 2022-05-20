using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

   
    void Update()
    {
        //            ↑(0,0,1)
        //(-1,0,0)←      →(1,0,0)
        //            ↓(0,0,-1)




        //Horizontal : 수평에 대한 정보로서 -1~1사이의 값을 반환합니다.
        float x = Input.GetAxis("Horizontal");
        //Vertical : 수직에 대한 정보로서 -1~1사이의 값을 반환합니다.
        float z = Input.GetAxis("Vertical");


        Vector3 dir = new Vector3(x, 0, z);


        //매 프레임마다 특정위치로 이동시키는 함수
        //normalizedf를 사용해서 단위벡터를 만들어줍니다.
        //백터의 크기를 1로 만들어줍니다.->대각선 이동을 하더라도 동일한 속도를 유지시키기 위해서
        
        transform.Translate(dir.normalized * speed*Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3
                (
                transform.position.x,
               3,
                transform.position.z
                );
        }
    }


    //물리적 충돌을 했을 때 동작하는 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");    
    }


    //물리적인 충동을 하고 있을때 동작하는 함수입니다.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    //물리적인 충동을 벗어났을 때 동작하는 함수입니다.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }

    //충돌조건
    //2개의 오브젝트 중 하나는 RigidBody를 가지고 있어야합니다.
    //2개의 오브젝트 모두 Collider 컴포넌트를 가지고 있어야합니다.
}
