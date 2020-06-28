using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ObjectManager;

public class BuildTable : MonoBehaviour
{
    // Start is called before the first frame update

    Collider col;

    void Start()
    {
        col = GetComponent<Collider>();    


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {

        if ( other.gameObject.GetComponent<FireworkIngredient>() )
        {
            print("Trigger Entered!");
            //Destroy(other.gameObject);
            
        }
    }
}
