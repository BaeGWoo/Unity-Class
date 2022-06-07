using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    //오브젝트가 화면밖으로 나갔을 경우 이벤트를 발생시키는 함수
    private void OnBecameInvisible()
    {
        rigid.velocity = Vector3.zero;
        gameObject.transform.position = new Vector3(0,5,0);
        ObjectPool.objpool.InsertQueue(gameObject);
        
    }
}
