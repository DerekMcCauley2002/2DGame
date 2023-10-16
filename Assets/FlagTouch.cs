using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTouch : MonoBehaviour
{
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Player")) {
            //Disable player movements
            player.canMove = false;
        }
    }
}
