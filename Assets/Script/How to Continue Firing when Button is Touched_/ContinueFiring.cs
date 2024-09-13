using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueFiring : MonoBehaviour
{
    private bool Isfire;
    public void PointerDown()
    {
        Invoke(nameof(FireTrue), 0.5f);
    }
    private void FireTrue()
    {
        Isfire = true;
        Invoke(nameof(FireTrue), 0.5f);

    }
    public void PointerUp()
    {
        Isfire = false;
        Debug.Log("UP");
    }
    private void Update()
    {
        if (Isfire)
        {
            Isfire = false;
            Invoke(nameof(FireTrue), 0.5f);

            Debug.Log("Fire");
        }
    }
}
