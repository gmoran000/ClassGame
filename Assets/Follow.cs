using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    public float distance;

    //public Rigidbody2D eb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        if (target.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        }
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }
        
        distance = Vector2.Distance(transform.position, target.transform.position);

        if (distance >= 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3 * Time.deltaTime);
        }
        
        transform.localScale = scale;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //This checks to see if the thing you bumped into had the Hazard tag
        //If it does...
        //if (other.gameObject.CompareTag("Wall"))
        //{
            //transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3 * Time.deltaTime);
            //transform.position = 
            //eb.position = other.contacts[0].point;
        //}
        
    }
}
