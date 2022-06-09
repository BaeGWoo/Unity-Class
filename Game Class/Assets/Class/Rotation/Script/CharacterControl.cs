using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 1.0f;
    public float mouseSpeed = 100.0f;
    float mX = 0.0f;
    float mY = 0.0f;

    CharacterController characterController;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
    }

   

    


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        characterController.Move(direction.normalized * speed * Time.deltaTime);


        //x,y,z,공간
        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed*Time.deltaTime, 0, Space.World);

        //회전 값 변수에 마우스 입력 값만큼 미리 누적을 시킵니다.
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");


        //회전 방향으로 물체를 회전시킵니다.
        //r =r0+vt

        //mX += mouseX * mouseSpeed * Time.deltaTime;
        //mY += mouseY + mouseSpeed * Time.deltaTime;

        //transform.eulerAngles = new Vector3(-mY, mX, 0);
    }
}
