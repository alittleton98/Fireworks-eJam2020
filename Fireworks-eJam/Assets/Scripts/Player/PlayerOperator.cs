using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorldObjects;

namespace Gameplay
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerOperator : MonoBehaviour
    {

        private string playerName;
        private Vector3 playerPos;
        private Rigidbody rb;
        private GameObject grabbedObject;

        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //playerName = ; Application management will provide this through platform SDK or simple entry
            playerPos = this.transform.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
            handlePlayer();
        }

        void handlePlayer()
        {
            movePlayer(); // handles player movement
            grabObject(); // handles player grabbed object 

        }
        void movePlayer()
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                this.playerPos.x = playerPos.x - .5f; // move player left -.5 meters per frame
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                this.playerPos.x = playerPos.x + .5f; // move player right +.5 meters per frame
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                this.playerPos.x = playerPos.z - .5f; // move player down -.5 meters per frame
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                this.playerPos.x = playerPos.z + .5f; // move player up +.5 meters per frame
            }
        }

        void grabObject() // may change return type to bool if identifying whether or not player holding something becomes important
        {
           //need to write grabbable object script and object observer first
        }
    }
}

