using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public int EnterCount = 0, ExitCount = 0;
    void OnTriggerEnter(Collider other){
        Debug.Log("Touched");
        EnterCount++;
        Debug.Log("The ammount touched is " + EnterCount);
    }
    void OnTriggerExit(Collider other){
        Debug.Log("Untouched");
        ExitCount++;
        Debug.Log("The ammount untouched is " + ExitCount);

    }
}
