using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace ObjectManager
{
    public class ObjectOperator : MonoBehaviour
    {
        ArrayList fireworkIngredients = new ArrayList();
        GameObject[] players = new GameObject[4];
        GameObject[] cameras = new GameObject[4];

        public ArrayList FireworkIngredients { get => fireworkIngredients; set => fireworkIngredients = value; }

        //create new lists as necessary

        // Start is called before the first frame update
        void Start()
        {
            gatherObjects(); //collects all objects in space at once
            Debug.Log(FireworkIngredients.Count);
        }

        // Update is called once per frame
        //method left empty if needed, but functions called every frame likely won't be called here and only called as necessary
        void Update()
        {

        }
        //following methods collect all corresponding objects (segmented by type)
        void gatherObjects()
        {
            gatherCameras();
            gatherPlayers();
            handleFireworkIngredients();
        }
        void gatherCameras()
        {
            cameras = GameObject.FindGameObjectsWithTag("Camera");
        }

        void gatherPlayers()
        {
            players = GameObject.FindGameObjectsWithTag("Player");
        }

        void handleFireworkIngredients()
        {
            //takes array of all firework ingredients present at first frame and loads them into corresponding ArrayList
            GameObject[] objArr = GameObject.FindGameObjectsWithTag("FireworkIngredient"); 
            foreach(GameObject i in objArr)
            {
                if (!FireworkIngredients.Contains(i))
                {
                    FireworkIngredients.Add(i);
                }
            }
            
        }
        //called explicilty by FireworkIngredient class
        void handleFireworkIngredients(GameObject fireworkIngredient)
        {
            FireworkIngredients.Add(fireworkIngredient); //adds firework ingredient to corresponding ArrayList
        }

        void destroyObject(GameObject gameObj, string tag)
        {
            //firework ingredients are currently the only objects to destroy dynamically
            //will be destroyed w/in Unity through FireworkIngredient Class
           if (FireworkIngredients.Contains(gameObj))
            {
                FireworkIngredients.Remove(gameObj);
            }
        }
        
    }

}

