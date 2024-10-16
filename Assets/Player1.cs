using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody2D RB;
    //This will control how fast the player moves
    public float Speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
        
        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }
    }
}
