using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    //Stack        Heap
                   //[]
    //int *ptr=new int(10);

    //delete ptr;
    //->delete 시 Heap영역의 값의 메모리를 해제한다.
    //그러면 ptr만 남게되는데 이 때 
    //*ptr=10;이라고 하면 이미 해제된 메모리 영역을 가리키는 포인터(댕글링 포인터)이기 때문에 터지게 된다.

    // Start is called before the first frame update
    void Start()
    {
        //생성할 오브젝트,  위치 , 회전(Quaternion.identity=>회전값이 0,0,0으로 초기화하는것을 의미)
        for (int i = 1; i <= 3; i++)
        {
            Instantiate(obj, new Vector3(0+3*i, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
