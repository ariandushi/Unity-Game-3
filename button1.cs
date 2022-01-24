using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public Button yourButton;
    public GameObject BallSCRIPT;
    public DrawLine dl;
    //Object prefabInstance = PrefabUtility.GetPrefabInstanceHandle(transform);
    
    void Start()
    {
        
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        BallSCRIPT.GetComponent<ballscr>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
