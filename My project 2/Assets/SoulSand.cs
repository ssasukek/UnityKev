using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulSand : MonoBehaviour
{
    public GameObject Player;
    public charMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = Player.GetComponent <charMovement>();
    }

    void OnTriggerEnter(Collider other){
        movement.Walk = movement.Walk/2;
        movement.Speed = movement.Speed/2;
    }
    void OnTriggerExit(Collider other){
        movement.Walk = 5;
        movement.Speed = 10;
    }
}
