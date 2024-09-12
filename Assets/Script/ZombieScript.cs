using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    [SerializeField] Animator anim;
    private string animName;
    private Rigidbody rb;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        ChangeAnim("Idle");
    }

    public void ChangeAnim(string animName)
    {
        if (this.animName != animName)
        {
            anim.ResetTrigger(this.animName);
            this.animName = animName;
            anim.SetTrigger(this.animName);
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = Vector3.forward * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(Vector3.zero);
            ChangeAnim("Walk");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector3.back * Time.deltaTime;
            transform.rotation = Quaternion.Euler(new Vector3(0, 180,0));
            ChangeAnim("Walk");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = Vector3.left * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(Vector3.left);
            ChangeAnim("Walk");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = Vector3.right * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(Vector3.right);
            ChangeAnim("Walk");
        }else {
            ChangeAnim("Idle");

        }

    }
}
