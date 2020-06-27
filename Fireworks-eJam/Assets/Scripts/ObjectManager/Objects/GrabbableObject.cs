using System.Collections;
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

        public Vector3 ObjectPos { get => objectPos; set => objectPos = value; }

        // Start is called before the first frame update
        public virtual void Awake()
        {
            ObjectPos = transform.localPosition;
            rb = GetComponent<Rigidbody>();
        }

    }
}

