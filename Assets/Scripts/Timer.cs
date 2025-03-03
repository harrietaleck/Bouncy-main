using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float currentTime;
    bool isRunning = false;

    [SerializeField] TextMeshProUGUI outputTime;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {

        if (isRunning)
        currentTime += Time.deltaTime;
        visualUpdate();

    }
    void StopTimer()
    {
    
    
    
    }

    void StartTimer().
    { 
        currentTime = 0;
        isRunning = true;

    }
    void visualUpdate()

    {

        outputTime.text = currentTime.ToString("HELLO");  // format the float to two decimal places

    }


}
