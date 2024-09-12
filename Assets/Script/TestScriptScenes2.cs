using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptScenes2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scenes 2 " +  PlayerPrefs.GetString("Name"));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
