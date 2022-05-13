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
      
      if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Update 함수입니다.");
        }
       
    }
}
