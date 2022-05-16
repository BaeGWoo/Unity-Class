using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;
    private MeshRenderer render;
    
  
    
    
    // Start is called before the first frame update
    private void Start()
    {
        render = GetComponent<MeshRenderer>();
      


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

        //엔터키를 눌렀을 때 동작
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("Paint", 3);
        }
       
    }

   

    public void Paint()
    {
        //Random.randge(?,?)->?와 ?사이의 난수값을 반환하는 클래스
        //0~2까지만 값을 가짐
        int value = Random.Range(0,3);
        switch(value)
        {
            case 0:
                render.material.color = Color.green;
                break;
            case 1:
                render.material.color = Color.red;
                break;
            case 2:
                render.material.color = Color.black;
                break;
        }


        //render라는 변수의 머티리얼 색상을 초록색으로 설정
       

    }

}
