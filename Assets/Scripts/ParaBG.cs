using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
[ExecuteInEditMode]
public class ParaBG : MonoBehaviour
{
    public Para parallaxCamera;
    List<ParaLayer> parallaxLayers = new List<ParaLayer>();
 
    void Start()
    {
        if (parallaxCamera == null)
            parallaxCamera = Camera.main.GetComponent<Para>();
 
        if (parallaxCamera != null)
            parallaxCamera.onCameraTranslate += Move;
 
        SetLayers();
    }
 
    void SetLayers()
    {
        parallaxLayers.Clear();
 
        for (int i = 0; i < transform.childCount; i++)
        {
            ParaLayer layer = transform.GetChild(i).GetComponent<ParaLayer>();
 
            if (layer != null)
            {
                layer.name = "Layer-" + i;
                parallaxLayers.Add(layer);
            }
        }
    }
 
    void Move(float delta)
    {
        foreach (ParaLayer layer in parallaxLayers)
        {
            layer.Move(delta);
        }
    }
}