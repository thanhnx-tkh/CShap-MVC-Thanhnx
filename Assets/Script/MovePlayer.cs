using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.up);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.down);
        }
    }
}
