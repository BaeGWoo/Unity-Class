using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject window;
    Animator animator;
    



    void Start()
    {
        animator = window.GetComponent<Animator>();
    }

    
    void Update()
    {
        //매니메이터 컨트롤러에서 현재 애니메이터 상태의 이름이 "Close"일 때
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                window.SetActive(false);
        }
    }

    public void Open()
    {
        window.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
