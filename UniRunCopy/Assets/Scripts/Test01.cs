using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "1";
        string userInput = "70";

        int number = int.Parse(userInput1);
        int value = int.Parse(userInput);

        if (number > 4 || number < 1 || value > 100 || value < 0)
        {
            Debug.Log("경고입니다");
            return;
        }

        string value2;
        if (number == 4)
        {
            if (value >= 70)
            {
                value2 = "합격";
            }
            else
            {
                value2 = "불합격";
            }
        }
        else
        {
            if (value>=60)
            {
                value2 = "합격";
            }
            else
            {
                value2 = "불합격";
            }
        }

        Debug.Log(number + "학년의 성적" + value+"점은" + value2+"입니다.");
    }


}
