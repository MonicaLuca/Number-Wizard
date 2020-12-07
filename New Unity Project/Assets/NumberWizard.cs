using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Think of you favorite number, and we will try to guess it!");
        Debug.Log("Do not select a number that is higher than " + max);
        Debug.Log("Make sure your number is not lower than " + min);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
