using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioManager;

    public AudioClip[] audioClip;

    private void Awake()
    {
        //신이 이동해도 파괴되지 않고 계속 유지되는 함수
        DontDestroyOnLoad(this.gameObject);
    }

    public void SoundVoulume(float Value) 
    {
        audioManager.volume = Value;
    }
    // Start is called before the first frame update
    void Start()
    {
        audioManager.clip = audioClip[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            audioManager.clip = audioClip[0];
            audioManager.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioManager.clip = audioClip[1];
            audioManager.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioManager.clip = audioClip[2];
            audioManager.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            audioManager.clip = audioClip[3];
            audioManager.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioManager.clip = audioClip[4];
            audioManager.Play();
        }
    }
}
