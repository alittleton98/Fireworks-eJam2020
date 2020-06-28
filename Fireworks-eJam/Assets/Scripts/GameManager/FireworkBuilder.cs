using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager
{
    public class FireworkBuilder : Firework
    {
        Firework compeletedFirework;
        FireworkIngredient[] ingredients = new FireworkIngredient[4];


       


        void addIngredient(FireworkIngredient ingredient)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null && !checkForDupIngredientType(ingredient))
                {
                    ingredients[i] = ingredient;
                }
            }
        }

        bool checkForDupIngredientType(FireworkIngredient ingredient)
        {
            bool areDupsPresent = false;
            foreach (FireworkIngredient i in ingredients)
            {
                if (i.Type == ingredient.Type)
                {
                    areDupsPresent = true;
                }
                else
                {
                    areDupsPresent = false;
                }
            }

            return areDupsPresent;
        }

        bool checkForCompletion(FireworkIngredient[] arr)
        {
            bool isCompleted = false;
            foreach (FireworkIngredient i in arr)
            {
                if(i == null)
                {
                    isCompleted = false;
                }
                else
                {
                    isCompleted = true;
                }
            }

            return isCompleted; 
        }








        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

