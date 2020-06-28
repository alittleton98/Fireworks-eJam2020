using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectManager
{

    enum FireworkColor
    {
        RED,
        GREEN,
        BLUE,
        GOLD
    }
    enum FireworkStyle
    {
        //will include different firework styles
        //idk what styles we want yet though
    }
    public enum IngredientType
    {
        HEAD,
        FUEL,
        EFFECT,
        TAIL
    }

    [RequireComponent(typeof(Rigidbody))]
    public class FireworkIngredient : GrabbableObject
    {
        FireworkColor color;
        FireworkStyle style;
        IngredientType type;

        float launchSpeedModifier;
        string explosionColorModifier;
        float explosionRadiusModifier;
        Random rand = new Random();

        public IngredientType Type { get => type; set => type = value; }

        // Start is called before the first frame update
        void Start()
        {
            base.Awake();
            gameObject.tag = "FireworkIngredient";
        }

        // Update is called once per frame
        void Update()
        {

        }

        
    }
}
