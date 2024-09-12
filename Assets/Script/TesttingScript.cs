using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesttingScript : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("Update" + Time.deltaTime);
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixupdate" + Time.deltaTime);
    }
    private void OnEnable() {
        Debug.Log("OnEnable");
        Invoke(nameof(OnDisable),3f);
    }

    private void OnDisable() {
    Debug.Log("OnDisable");

    }
}
