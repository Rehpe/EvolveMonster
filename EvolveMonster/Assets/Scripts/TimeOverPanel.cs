using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOverPanel : MonoBehaviour
{
    public GameObject RetryPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoRetry()
    {
        gameObject.SetActive(false);
        RetryPanel.SetActive(true);

    }
}
