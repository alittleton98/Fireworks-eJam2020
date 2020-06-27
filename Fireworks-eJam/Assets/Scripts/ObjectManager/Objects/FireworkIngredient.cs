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
    enum IngredientType
    {
        HEAD,
        FUEL,
        EFFECT,
        TAIL
    }
    
    public class FireworkIngredient : GrabbableObject
    {
        FireworkColor color;
        FireworkStyle style;
        IngredientType type;

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
