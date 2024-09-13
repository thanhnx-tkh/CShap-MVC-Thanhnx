using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TesttingScript : MonoBehaviour
{
    static WebCamTexture webCamTexture;
    private void Start() {
        webCamTexture = new WebCamTexture();
        GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }
}
