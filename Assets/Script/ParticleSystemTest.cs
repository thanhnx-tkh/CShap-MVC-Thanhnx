using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemTest : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
