using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    
    [SerializeField]
    [Range(0, 2)]
    private float Cooldown;

    [SerializeField]
    Transform[] Teleporters;

    private float TimeTouchWall = 0;

    private bool Touch = true;
    // Start is called before the first frame update
    
    private void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        TimeTouchWall = 0;
    }
    private void OnCollisionExit(Collision other)
    {
        //Debug.Log("SALGO DE LA COLISION ->" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        TimeTouchWall += Time.deltaTime;
        if(TimeTouchWall >= Cooldown && Touch)
        {
            if (collision.gameObject.CompareTag("Pared"))
            {
                Touch = false;
                collision.transform.position = Teleporters[0].position;
                collision.transform.rotation = Teleporters[0].rotation;
            }
            
        } else if (TimeTouchWall >= Cooldown && Touch == false)
        {
            if (collision.gameObject.CompareTag("Pared"))
            {
                Touch = true;
                collision.transform.position = Teleporters[1].position;
                collision.transform.rotation = Teleporters[1].rotation;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }

}
