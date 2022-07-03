using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int waypointCount;
    [SerializeField] int totalLaps;
    [SerializeField] int waypointIndex;
    [SerializeField] int currentLap;
    float startTime;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI waypointText;
    bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        //find gameobject by name
        timeText = GameObject.Find("TimeText").GetComponent<TextMeshProUGUI>();
        waypointText = GameObject.Find("waypointText").GetComponent<TextMeshProUGUI>();
        waypointText.enabled = false;
        timeText.enabled = false;
        CarUserControl.controls.Disable();
        
        //startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString("D2");
        decimal convertedSeconds = Math.Round((decimal)t % 60, 3);
        //Debug.Log(convertedSeconds);
        
        timeText.text = minutes + ":" + convertedSeconds.ToString();
        
    }
    
    public void enterWaypoint()
    {
        waypointIndex++;
        if (waypointIndex >= waypointCount)
        {
            waypointIndex = 0;
            currentLap++;

            if (currentLap >= totalLaps)
            {
                StartCoroutine(waypointTime());
                //Debug.Log("You won!");
            }
            else
            {
                if (isRunning)
                {
                    StopCoroutine(waypointTime());
                }
                StartCoroutine(waypointTime());
            }

        }
    }

    IEnumerator waypointTime()
    {
        isRunning = true;
        waypointText.enabled = true;
        waypointText.alpha = 1;
        waypointText.text = timeText.text;
        
        yield return new WaitForSeconds(2f);
        
        while (true)
        {
            float oldAlpha = waypointText.alpha;
            if (oldAlpha <= 0)
            {
                waypointText.enabled = false;
                isRunning = false;
                break;
            }
            oldAlpha -= .01f;
            waypointText.alpha = oldAlpha;
            yield return new WaitForSeconds(0.01f);
        }
        
        Debug.Log("coroutine finished");
        yield return null;
    }

    public void enableUIAndCar()
    {
        startTime = Time.time;
        CarUserControl.controls.Enable();
        timeText.enabled = true;
    }

}
