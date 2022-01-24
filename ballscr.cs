using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscr : MonoBehaviour
{
    public GameObject bll;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        statement1();
    }
    void statement1()
    {
        if (bll.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Static)
        {
            bll.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}