using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //This script is made so that I can do code demos.
    //I will be showing how things work in Start(), using UpdateText() to make the code's results show on-screen

    public TextMeshPro Text;
    
    void Start()
    {
        int x = 5;
        
        UpdateText(x);
    }

    //You can ignore me. This is just the code that makes the text update.
    public void UpdateText(object result)
    {
        Text.text = result.ToString();
    }
}
