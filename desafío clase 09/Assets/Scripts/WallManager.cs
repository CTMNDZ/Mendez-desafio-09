using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    
    [SerializeField]
    [Range(2, 10)]
    private float cooldown;

    [SerializeField]
    Transform nextPortal;

    private float timeInPortal = 0;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        timeInPortal = 0;
    }

    private void OnCollisionStay(Collision other)
    {   
            timeInPortal += Time.deltaTime;
                
            if (timeInPortal >= cooldown)
                {
                    other.transform.position = nextPortal.position;
                }

    }
    private void OnCollisionExit(Collision other)
    {

    }
}
