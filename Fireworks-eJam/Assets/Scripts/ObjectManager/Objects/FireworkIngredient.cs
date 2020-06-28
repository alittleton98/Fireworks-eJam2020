using ObjectManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectManager
{

    public enum FireworkColor
    {
        RED,
        GREEN,
        BLUE,
        GOLD
    }
    public enum FireworkStyle
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
    
    public class FireworkIngredient : GrabbableObject
    {
        FireworkColor color;
        FireworkStyle style;
        IngredientType type;

        float launchSpeedModifier;
        string explosionColorModifier;
        float explosionRadiusModifier;
        System.Random random = new System.Random();

        public IngredientType Type { get => type; set => type = value; }
        public FireworkStyle Style { get => style; set => style = value; }
        public FireworkColor Color { get => color; set => color = value; }

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

        IngredientType ingredientTypeRandomSelector()
        {
            IngredientType[] arr = (IngredientType[])Enum.GetValues(typeof(IngredientType));
            return arr[random.Next(arr.Length)];
        }
        
        FireworkColor colorRandomSelector()
        {
            FireworkColor[] arr = (FireworkColor[])Enum.GetValues(typeof(FireworkColor));
            return arr[random.Next(arr.Length)];
        }

        private void OnCollisionEnter(Collision collision)
        {
            
        }
    }
}
