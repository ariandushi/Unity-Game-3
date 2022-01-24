using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPlayButton : MonoBehaviour
{
    public Button clickButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = clickButton.GetComponent<Button>();
        btn.onClick.AddListener(WhenClicked);
    }
    void WhenClicked()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
