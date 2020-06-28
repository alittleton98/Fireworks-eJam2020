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
        GameObject objectBeingHeld;

        public CharacterController controller;

        public float speed = 6f;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //playerName = ; Application management will provide this through platform SDK or simple entry
            playerPos = this.transform.localPosition;
            objectOperator = GetComponent<ObjectOperator>();
            Debug.Log(" type == " + objectOperator.GetType().Name);

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
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(h, 0f, v).normalized;

            if (direction.magnitude >= 0.1f)
            {
                controller.Move(direction * speed * Time.deltaTime);
            }
        }

        void grabObject() // may change return type to bool if identifying whether or not player holding something becomes important
        {
            foreach (GameObject i in objectOperator.FireworkIngredients)
            {
                if (Vector3.Distance(i.transform.position, playerPos) <= 1.5f)
                {
                    i.GetComponent<Rigidbody>().isKinematic = false;
                    i.transform.parent = this.transform;
                    holdingObject = true;
                    objectBeingHeld = i;
                    objectBeingHeld = i;
                    Debug.Log("Holding Object");
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

