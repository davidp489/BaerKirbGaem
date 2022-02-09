using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityManager : MonoBehaviour
{
    public int sanityMeter;

    // Start is called before the first frame update
    void Start()
    {
        sanityMeter = 75;
    }

    private void OnTriggerExit2D(Collider2D collider) // When entering dark/danger zone, sanity meter goes down
    {
        while(sanityMeter != 0)
        {
            StartCoroutine(sanityDown());
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) // When entering light/safe zone, sanity meter goes up
    {
        if(collider.gameObject.CompareTag("Light")) //Checks if the player entered the light area
        {
            while(sanityMeter != 100)
            {
                StartCoroutine(sanityUp());
            }
        }
    }

    IEnumerator sanityUp()
    {
        sanityMeter++;
        Debug.Log("Scheise");
        yield return new WaitForSeconds(4);
    }

    IEnumerator sanityDown()
    {
        sanityMeter--;
        Debug.Log("DoppeltScheise");
        yield return new WaitForSeconds(4);
    }
}
