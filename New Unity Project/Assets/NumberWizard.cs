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
        Debug.Log("Think of your favorite number, and we will try to guess it!");
        Debug.Log("Do not select a number that is higher than " + max);
        Debug.Log("Make sure your number is not lower than " + min);

        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");

        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }

    }
}
