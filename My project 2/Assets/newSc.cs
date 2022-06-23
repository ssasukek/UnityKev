using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSc : MonoBehaviour
{
    // public int test = 500;
    // public bool answerOne;
    // public string test2 = "coffee";
    // public bool answerTwo;
    // private double timeToDinner = 4.0;
    // public double rate = 30.0;
    // public double distance = 95.0;
    // public double tripDuration;
    // public bool answer;
    
    // Start is called before the first frame update
    void Start()
    {
        // if(test > 24){
        //     answerOne = true;
        // }
        // Debug.Log(answerOne);
        // answerTwo = test2.Contains("a");
        // Debug.Log(answerTwo);
        // tripDuration = distance/rate;
        // answer = tripDuration <= timeToDinner;
        // Debug.Log(answer);
        // Debug.Log(tripDuration);

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetAxis("Horizontal") > 0){
                Debug.Log("I am moving to the right");
            }
            else if(Input.GetAxis("Horizontal") < 0){
                Debug.Log("I am moving to the left");
            }
    }
}
