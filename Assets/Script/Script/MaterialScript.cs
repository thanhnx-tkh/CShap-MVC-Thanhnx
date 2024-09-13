using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public MeshRenderer meshRenderer;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();

        Invoke(nameof(ChangeMatel),3f);
        Invoke(nameof(ChangeMatel2),3f);

    }
    public void ChangeMatel(){
        meshRenderer.material = material1;
    }
    public void ChangeMatel2(){
        meshRenderer.material = material2;
    }

}
