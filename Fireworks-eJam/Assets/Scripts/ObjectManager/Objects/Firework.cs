using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;
using System;
using System.Linq;

namespace ObjectManager
{
    public class Firework : MonoBehaviour
    {
        FireworkIngredient[] ingredients = new FireworkIngredient[4];
        FireworkRecipe recipe;
        bool isCompleted = false;
        float explosionRadius = 10f;
        string explosionColor = "default";
        float launchSpeed = 10f;
        int completionRating = 5;

        public FireworkRecipe Recipe { get => recipe; set => recipe = value; }
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
        public float ExplosionRadius { get => explosionRadius; set => explosionRadius = value; }
        public string ExplosionColor { get => explosionColor; set => explosionColor = value; }
        public float LaunchSpeed { get => launchSpeed; set => launchSpeed = value; }
        public int CompletionRating { get => completionRating; set => completionRating = value; }

        // Update is called once per frame
        void Update()
        {

        }

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
            bool areDupsPresent =  false;
            foreach (FireworkIngredient i in ingredients)
            {
                if (i.Type == ingredient.Type)
                {
                    areDupsPresent=  true;
                }
                else
                {
                    areDupsPresent = false;
                }
            }

            return areDupsPresent;
        }

        FireworkIngredient[] GetFireworkIngredients()
        {
            return ingredients;
        }

        void incrementCompletionRating()
        {
            completionRating++;
        }

        void decrementCompletionRating()
        {
            completionRating--;
        }

        void variableCalculations(FireworkIngredient fireworkIngredient, string type)
        {

        }

    }
}

