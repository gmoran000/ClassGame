using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2 : MonoBehaviour
{
    public PlayerScript Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (transform.position.x > Player.transform.position.x)
        {
            pos.x -= 0.1f ; //3 * Time.deltaTime
        }
        
        if (transform.position.x < Player.transform.position.x)
        {
            pos.x += 0.1f;
        }
        
        if (transform.position.y > Player.transform.position.y)
        {
            pos.y -= 0.1f;
        }
        
        if (transform.position.y < Player.transform.position.y)
        {
            pos.y += 0.1f;
        }
        
        transform.position = pos;
        
    }
}
