using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").GetComponent<Animator>().SetBool("IsMove",true);
        GameObject.Find("Sphere").GetComponent<Animator>().SetBool("IsMove",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
