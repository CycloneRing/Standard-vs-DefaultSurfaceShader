using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitch : MonoBehaviour
{
    public Renderer renderer;
    public Material std, surface;
    public UnityEngine.UI.Text currentMtl;

    public void SetStandardMaterial()
    {
        renderer.material = std;
        currentMtl.text = "Standard Shader";
    }
    
    public void SetDefaultSurfaceMaterial()
    {
        renderer.material = surface;
        currentMtl.text = "Default Surface Shader";
    }
}
