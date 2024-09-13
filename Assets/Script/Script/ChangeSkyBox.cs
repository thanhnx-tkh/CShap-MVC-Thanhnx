using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public Material material3;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = material1;
        Invoke(nameof(Change), 5f);
    }
    private void Change()
    {
        RenderSettings.skybox = material2;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
