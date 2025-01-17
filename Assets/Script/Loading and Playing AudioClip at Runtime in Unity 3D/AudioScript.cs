using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("time_for_adventure");
        meshRenderer.material = Resources.Load<Material>("Earth Material");
        audioSource.PlayDelayed(2f);
    }
    private void AudioFinish(){
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
