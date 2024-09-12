using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            rigidbody.AddForce(Vector3.up,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rigidbody.AddForce(Vector3.down,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rigidbody.AddForce(Vector3.left,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rigidbody.AddForce(Vector3.right,ForceMode.VelocityChange);
        }
    }
}
