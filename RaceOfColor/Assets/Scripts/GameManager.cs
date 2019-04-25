using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] Kupler = new GameObject[4];
    public GameObject zemin, zemin1, zemin2, zemin3;
    float hiz = -6;
    float KupOlusumSuresi = 1.1f;
    Vector3[] KupYeri = new Vector3[4];
    int KupIndis = 0;
    int YerIndis = 0;
    int HizSayaci = 0;
   // int Kalpİhtimal = 0;

    

    void Start()
    {
        KupYeri[0] = new Vector3(-0.643f,0.151f,50f);
        KupYeri[1] = new Vector3(-0.21f,0.151f,50f);
        KupYeri[2] = new Vector3(0.222f,0.151f,50f);
        KupYeri[3] = new Vector3(0.664f,0.151f,50f);
        zemin.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        zemin3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
        StartCoroutine(KupOlustur());      
    }


    void Update()
    {
   
    }

    public IEnumerator KupOlustur()
    {
        while (true)
        {

            KupIndis = Random.Range(0, 4);
            YerIndis = Random.Range(0, 4);
            GameObject YeniKup = Instantiate(Kupler[KupIndis], KupYeri[YerIndis], Quaternion.identity);
            YeniKup.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
            HizSayaci++;
            Debug.Log(HizSayaci);
            if ( HizSayaci % 100 == 0  && HizSayaci < 1002)
            {
                hiz = hiz - 0.5f;
                KupOlusumSuresi = KupOlusumSuresi - 0.1f;
                zemin.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
                zemin1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
                zemin2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
                zemin3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, hiz);
            }
            yield return new WaitForSeconds(KupOlusumSuresi);

        }
       
    }


    
}
