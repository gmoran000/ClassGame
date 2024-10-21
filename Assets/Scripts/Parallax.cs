using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;
    
    Vector2 startPosition;
    private float startz;

    private Vector2 travel => (Vector2)cam.transform.position - startPosition;
    
    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingPLane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));
    
    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPLane;

    public void Start()
    {
        startPosition = transform.position;
        startz = transform.position.z;
        
    }

    public void Update()
    {
        Vector2 newPos = startPosition + travel;
        transform.position = new Vector3(newPos.x, newPos.y, startz);
    }
}
