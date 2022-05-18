using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        //생성할 오브젝트,  위치 , 회전(Quaternion.identity=>회전값이 0,0,0으로 초기화하는것을 의미)
        for (int i = 0; i <= 3; i++)
        {
            Instantiate(obj, new Vector3(0+3*i, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
