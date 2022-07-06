using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator tAnim;
    // Start is called before the first frame update
    void Start()
    {
        tAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            tAnim.SetBool("isWalking", true);
        }
        else{
            tAnim.SetBool("isWalking", false);
        }

        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w")){
            tAnim.SetBool("isRunning", true);
        }
        else{
            tAnim.SetBool("isRunning", false);
        }
    }
}
