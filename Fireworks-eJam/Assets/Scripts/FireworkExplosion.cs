using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.VFX;

public class FireworkExplosion : MonoBehaviour
{


    // Start is called before the first frame update

    public VisualEffect effect;

    public int count = 5;

    [ColorUsage(true, true)]
    public Color trailColor;

    public float blastVelocity = 5;


    public void Explode()
    {

        effect = GetComponent<VisualEffect>();

        Gradient gradient;
        GradientColorKey[] colorKey;
        GradientAlphaKey[] alphaKey;

        effect.SetInt("Count", count);



        // Set Particle Color
        gradient = new Gradient();

        // Populate the color keys at the relative time 0 and 1 (0 and 100%)
        colorKey = new GradientColorKey[2];
        colorKey[0].color = trailColor;
        colorKey[0].time = 0.0f;
        colorKey[1].color = trailColor;
        colorKey[1].time = 1.0f;

        // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;
        gradient.SetKeys(colorKey, alphaKey);

        effect.SetGradient("TrailColor", gradient);

        effect.SetFloat("BlastVelocity", blastVelocity);

        effect.Play();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
