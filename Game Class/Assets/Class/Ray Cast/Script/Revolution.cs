using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;
    public float speed;
    //스페이스를 눌렀을 대 속도가 10 증가하도록 설정
    //속도가 100이 넘어가게 되면 다시 0으로 설정
    
    // Update is called once per frame
    void Update()
    {
        //기준점, 회전축, 속도
        transform.RotateAround(origin.transform.position, Vector3.down, speed * Time.deltaTime);    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (speed < 100)
                speed += 10;
            else
                speed = 0;
        }
    
    
    }
}
