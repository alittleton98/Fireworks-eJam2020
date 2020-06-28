using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkRocket : MonoBehaviour
{
    // Start is called before the first frame update

    public float fuseTime = 2f;
    private float startTime;

    public GameObject Explosion;

    public int count = 5;

    [ColorUsage(true, true)]
    public Color trailColor;

    public float blastVelocity = 5;

    public float rocketSpeed = 2f;
    void Start()
    {

        startTime = Time.time;


    }

    // Update is called once per frame
    void Update()
    {

        float offset = rocketSpeed * Time.deltaTime;
        gameObject.transform.position += new Vector3(0, offset, 0);

        if (Time.time - startTime >= fuseTime)

        {

            GameObject newExplosion = Instantiate(Explosion);

            FireworkExplosion exp = newExplosion.GetComponent<FireworkExplosion>();
            exp.trailColor = trailColor;
            exp.blastVelocity = blastVelocity;
            exp.count = count;
            exp.Explode();

            newExplosion.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
    }

}
