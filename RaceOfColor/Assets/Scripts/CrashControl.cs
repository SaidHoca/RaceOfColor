using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashControl : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerExit(Collider other)
    {
        if ( other.transform.tag == "zemin")
        {
            other.transform.position = new Vector3(0, 0, other.transform.position.z + 90);
        }
        else
        {
            Destroy(other.gameObject);
        }
        
    }
}
