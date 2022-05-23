using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    public int Health = 100;
    public float speed;
    Rigidbody rigid;
    Vector3 dir;
    public bool condition = false;

  
    

    void Start()
    {
        rigid=GetComponent<Rigidbody>();
    }

    private void Update()
    {
     if(Health<=0)
        {
            gameObject.SetActive(false);
        }
        
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //AddForce : 객체에 일정한 힘을 가하는 함수
            if (condition)
                rigid.AddForce(new Vector3(0, 300, 0));
        }

    }

    private void FixedUpdate()
    {


        rigid.MovePosition
            (
            rigid.position +
            dir *
            speed *
            Time.deltaTime
            );
        
    }


    //물리적 충돌을 했을 때 동작하는 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        condition = true;

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
        condition = false;
    }

    //충돌조건
    //2개의 오브젝트 중 하나는 RigidBody를 가지고 있어야합니다.
    //2개의 오브젝트 모두 Collider 컴포넌트를 가지고 있어야합니다.


    //onTriggerEnter : 물리적인 충동을 하지 않고 충돌처리를 하는 함수

    //물리적인 충동을 하지 않고 충돌을 했을 때 동작하는 함수

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("감지");
        Health -= 50;
    }


    //물리적인 충동을 하지 않고 충동을 하고있을때 동작하는 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    //물리적인 충동을 하지 않고 충동을 벗어났을 때
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
