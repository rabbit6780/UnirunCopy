using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] score = new int[] { 10, 20, 30, 40, 50 };

        foreach( int a in score)
        {
            Debug.Log("5명 학생의 평균은 " + "score/5");
        }
    }
