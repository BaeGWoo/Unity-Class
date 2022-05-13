using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    


    //Awake함수는 Start함수 이전에 한 번만 호출되는 함수
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }
    // Start is called before the first frame update
    //start함수는 게임 시작할 때 한 번만 호출되는 함수입니다.
    void Start()
    {
        /*
        transform.position += new Vector3
                 (
                 transform.position.x,
                  transform.position.y,
                   transform.position.z + 1
                 );
        */
       
        Debug.Log("Start 함수입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        //60프레임일때 : left + 프레임 속도 *0.016
        //30프레임일때 : left + 프레임 속도 * 0.03
        Debug.Log(Time.deltaTime);

      if(Input.GetKey(KeyCode.A))
        {
            //Vector3.left=(-1,0,0);을 의미한다
            transform.position += Vector3.left*Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            //Vector3.forward=(0,0,1);을 의미한다
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Vector3.forward=(0,0,-1);을 의미한다
            transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Vector3.forward=(1,0,0);을 의미한다
            transform.position += Vector3.right * Time.deltaTime;
        }

    }
}
