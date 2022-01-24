using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newparticle : MonoBehaviour
{
    public GameObject anima;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("has entered");
        anima.gameObject.SetActive(false);

    }
    void Update()
    {
        
    }
}
