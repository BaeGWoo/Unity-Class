using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//입력한 글자를 uj에 띄우기 위해서 참조
using UnityEngine.UI;
public class Problem : MonoBehaviour
{
    public InputField input;
    public Text answer;


    //과잉수
    
     //  public int a = 20;

        int function(int n) 
        {
            int sum = 0;
            for(int i=1;i<n;i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }
        private void Start()
        {

            //answer.text = input.text;
        }

        private void Update()
        {

        //string variable = answer.text.ToString();
        string variable = input.text.ToString();
        int a;
        int.TryParse(variable, out a);

            if (function(a) > a)
                answer.text = "과잉수입니다.";
            else
                answer.text = "과잉수가 아닙니다.";


        }
    



    //회문 판별
    /*
    public string variable="noon";
    bool result = true;
    private void Start()
    {
        int length = variable.Length-1;
        for(int i=0;i<length;i++)
        {
            if (variable[i] != variable[length - i])
                result = false;
        }
        if (result)
            answer.text = "true";
        else
            answer.text = "false";
    }
    */
}

