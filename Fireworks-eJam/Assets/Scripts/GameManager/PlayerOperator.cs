using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectManager;

namespace GameManager
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Player))]
    public class PlayerOperator : Player
    {
        private Vector3 playerPos;
        private Rigidbody rb;
        private GameObject grabbedObject;
        ObjectOperator objectOperator;
        bool holdingObject = false;
        FireworkIngredient objectBeingHeld;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //playerName = ; Application management will provide this through platform SDK or simple entry
            playerPos = this.transform.localPosition;
            objectOperator = GetComponent<ObjectOperator>();
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
            foreach (FireworkIngredient i in (ArrayList)objectOperator.FireworkIngredients)
            {
                if (Vector3.Distance(i.ObjectPos, playerPos) <= 1.5f)
                {
                    i.transform.parent = gameObject.transform;
                    holdingObject = true;
                    objectBeingHeld = i;
                    i.Rb.isKinematic = false;
                }

            }
        }

        void dropObject()
        {
            objectBeingHeld.transform.parent = null;
            objectBeingHeld = null;
            holdingObject = false;
        }
    }
}

