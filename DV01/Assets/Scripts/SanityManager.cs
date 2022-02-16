using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class SanityManager : MonoBehaviour
{
    public int sanityMeter;
    private bool isLight;
    

    // Start is called before the first frame update
    void Start()
    {
        sanityMeter = 80;
        StartCoroutine(sanity());
    }

    private void OnTriggerExit2D(Collider2D collider) // When entering dark/danger zone, sanity meter goes down
    {
        isLight = false;
    }

    private void OnTriggerEnter2D(Collider2D collider) // When entering light/safe zone, sanity meter goes up
    {
        if(collider.gameObject.CompareTag("Light")) //Checks if the player entered the light area
        {
            isLight = true;
        }
    }

    IEnumerator sanity()
    {
        while(true)
        {
            if(isLight)
            {
                if(sanityMeter < 100)
                {
                    sanityMeter++;
                }
            }
            else
            {
                if(sanityMeter > 0)
                {
                    sanityMeter--;
                }
            }
            yield return new WaitForSeconds(4);
        }
    }

    
}
