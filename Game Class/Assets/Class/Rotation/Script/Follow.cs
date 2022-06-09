using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Character;



  
    void Update()
    {

        //자기 자신의 위치, 캐릭터의 위치>10
        if(Vector3.Distance(transform.position,Character.transform.position)>=5)
        {

            //짐벌락 현상
            //회전을 하다가 두 축이 겹치게 되어 한 축의 역활을 사라지는 현상이 발생
            //quaternion 사함수를 이용하여 4차원 축(x,y,z,w)을 하나 더 생성

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            //LookAt : 대상을 바라보도록 설정하는 함수
            transform.LookAt(Character.transform);
        }
       
    }
}
