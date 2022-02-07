using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityMeter : MonoBehaviour
{

    public int sanityMeter = 70;
    public GameObject dangerZone;
    // Start is called before the first frame update
    void Start()
    {
        dangerZone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DangerousArea()
    {
        // Sanity goes down
        dangerZone.SetActive(true);
        while(sanityMeter != 0)
        {
            sanityMeter -= 1;
        }
        gameOver();
    }

    public void gameOver()
    {

    }

    public void PositiveArea()
    {
        // Sanity goes up
        while(sanityMeter != 100)
        {
            sanityMeter += 1;
        }
    }

    public void sanityNeutral()
    {
        while(sanityMeter > 70)
        {
            sanityMeter -= 1;
        }
    }
}
