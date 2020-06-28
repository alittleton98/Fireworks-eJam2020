using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectManager;

namespace GameManager
{
    public class FireworkBuilder : Firework
    {
        FireworkIngredient[] loadedIngredients = new FireworkIngredient[4];

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void callFireworkAssembly(Collider collider)
        {
            
            if (checkForCompletion(loadedIngredients))
            {
                assembleFirework(loadedIngredients);
            }
        }

        Firework assembleFirework(FireworkIngredient[] fireworkIngredients)
        {
            Firework completedFirework = new Firework();
            
            foreach(FireworkIngredient i in fireworkIngredients)
            {
                if (!checkForDupIngredientType(i))
                {
                    completedFirework.addIngredient(i);
                }
            }

            return completedFirework;
        }

        bool checkForDupIngredientType(FireworkIngredient ingredient)
        {
            bool areDupsPresent = false;
            foreach (FireworkIngredient i in loadedIngredients)
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
                if (i == null)
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

    }
}

