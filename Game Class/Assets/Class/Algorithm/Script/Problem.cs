using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//입력한 글자를 uj에 띄우기 위해서 참조
using UnityEngine.UI;
public class Problem : MonoBehaviour
{
    public InputField input;
    public Text answer;

    //형변환(string->int)
    //int.TryParse(variable, out a);

    //int[] numberChek = new int[5];
   
    private void Update()
    {

       
    }



    //팩토리얼
    /*

    string variable = input.text.ToString();
    int a;
    int.TryParse(variable, out a);

    answer.text = Factorial(a).ToString();
    public long Factorial (int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    */

    //완벽한 문자열
    /*
    private void Update()
    {

        string variable = input.text.ToString();
        bool result = true;
        for(int i=0;i<variable.Length;i++)
        {
            //int number=(int)char.GetNumericValue(variable[i]);
            //int low = (int)char.GetNumericValue('A');
            //int up = (int)char.GetNumericValue('z');

            int number = (int)variable[i];
            int low = (int)'A';
            int up = (int)'z';
            if (!(number>low&&number<up))
            {
                result = false;
                break;
            }
        }


        if (result)
            answer.text = "완전문자열입니다.";
        else
            answer.text = "완전문자열이 아닙니다.";


    }
    */

    //과잉수
    /*
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


   */

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

    //중복되지 않는 랜덤값
    /*
    private void RandomNumber()
    {
        int checkNumber = 0;
        for (int i = 0; i < numberChek.Length; i++)
        {
            if (numberChek[i] == 1)
            {
                checkNumber++;
            }
        }

        if (checkNumber == 5)
        {
            Debug.Log("전부생성완료");
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            int number = Random.Range(1, 6);
            if (numberChek[number - 1] == 0)
            {
                Debug.Log(number);
                numberChek[number - 1] = 1;
            }
            else
                RandomNumber();
        }
    }

    */
}

