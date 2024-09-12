using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").GetComponent<Animator>().speed =100;
        GameObject.Find("Sphere").GetComponent<Animator>().speed =100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
