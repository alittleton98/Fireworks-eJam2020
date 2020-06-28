using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager
{
    public class GameOperator : MonoBehaviour
    {
        ObjectOperator objectOperator;
        float timeRemaining; //time for the player to complete the level
        Firework[] toBeLaunched = new Firework[5];
        FireworkRecipe[] fireworkRecipeRequests = new FireworkRecipe[10];
        int totalPoints = 0;
        int accuracyRating = 0;

        public void handleFireworkAssembly(FireworkIngredient ingredient)
        {
            
        }

        //Called upon game loading
        private void Awake()
        {
            
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

