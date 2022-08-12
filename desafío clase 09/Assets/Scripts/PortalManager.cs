using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    // Start is called before the first frame update+
        private PlayerData playerData;

    
    private void Start()
    {
        playerData = GetComponent<PlayerData>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            playerData.Shrink();
        }
    }

}
