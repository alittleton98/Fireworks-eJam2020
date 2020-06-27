﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectManager
{
    public class GrabbableObject : MonoBehaviour
    {
        private string tag;
        private Vector3 objectPos;
        private Player objectHolder;
        private Rigidbody rb; //only use if objects are given physics requirements

        // Start is called before the first frame update
        public virtual void Awake()
        {
            objectPos = transform.localPosition;
            rb = GetComponent<Rigidbody>();
        }

    }
}

