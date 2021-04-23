using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBehavior : MonoBehaviour
{

    [SerializeField]
    //The timer text

    public Text timerText;

    [SerializeField]
    //Shows how long since the application started
    private float startTime;


    bool timerActive = true;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = startTime.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
       if (timerActive)
        {
            startTime += Time.deltaTime;
            timerText.text = startTime.ToString("F2");
        }
    }
}
