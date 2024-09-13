using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform pointFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire(){
        if(Input.GetMouseButtonDown(0)){
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = pointFire.position;
            bullet.GetComponent<Rigidbody>().velocity = Vector3.forward*Time.deltaTime*100;            
            Destroy(bullet, 5f);
        }
    }
}
