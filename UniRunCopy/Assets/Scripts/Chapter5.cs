using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 10;

        while(i>0)
        {
            Debug.Log($"i : {i--}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
