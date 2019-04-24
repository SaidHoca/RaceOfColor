using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Kirmizi,zemin, zemin1, zemin2 , zemin3;
    public int hiz = -5;

    void Start()
    {
        Kirmizi.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
    }


    void Update()
    {
   
    }
}
