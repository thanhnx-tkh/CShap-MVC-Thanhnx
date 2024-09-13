using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.transform.name == "Cube"){
                SceneManager.LoadScene("Scene1");
            }
        } 
    }
}
