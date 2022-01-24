using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlee : MonoBehaviour
{
    public float timeout = 7F;
    public GameObject anim;
    private float timeRemaining;
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeout;
        anim.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("has entered");
        anim.gameObject.SetActive(true);
        active = true;

    }
    void Update()
    {
        /*if(timeRemaining > 0)
        {
            timeRemaining = timeRemaining - Time.deltaTime;
        }
        else
        {
            timeRemaining = timeout;
            anim.gameObject.SetActive(false);
        }*/
    }

}
