using ObjectManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager
{
    public class GameOperator : MonoBehaviour
    {
        float timeRemaining;
        Firework[] toBeLaunched = new Firework[5];
        FireworkRecipe[] fireworkRecipeRequests = new FireworkRecipe[10];
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

