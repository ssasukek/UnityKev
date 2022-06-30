using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject Character;
    public Light myLight;
    public AudioSource juke;
    // Start is called before the first frame update
     void Start()
    {
        myLight = GetComponent<Light>();
        juke = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        myLight.intensity = 0f;
        juke.Play();
    }
    void OnTriggerExit(Collider other)
    {
        myLight.intensity = 1f;
        juke.Stop();
    }

}
