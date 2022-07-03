using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading;
using System.Diagnostics;

public class Waypoint : MonoBehaviour
{
    public int waypointsMet;   //how many waypoints have been hit
    public int waypointCount;  //how many are there in the level

    public int lapsMet;        //how many laps have been done
    public int lapCount;       //how many laps are in the level

    public TextMeshProUGUI waypointTimeText;
    public TextMeshProUGUI lapsText;

    public TextMeshProUGUI timeText;
   
    public string timeString = "0";  //total time in string format

    Thread time;  //declare the thread outside so other methods can abort

    public bool hasStarted = false;    //has the user started the time trial?

    Stopwatch timer = new Stopwatch();     //using C#'s stopwatch feature for the timer

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = true;
        lapsText.text = lapsMet.ToString() + "/" + lapCount.ToString();

        time = new Thread(delegate ()
        {
            lapTimer();
        });
        time.Start();

        

    }

    /// <summary>
    /// Multi-threading for the lap timer
    /// </summary>
    void lapTimer()
    {

        
        timer.Start();


        while (hasStarted == true)
        {
            timeString = timer.Elapsed.ToString("mm\\:ss\\.ff");              //while loop to make sure the thread stays stuck here until the user finishes, leaves, or resets
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = timeString;          //every frame update the time

        if (Input.GetKey("escape"))
        {
            Application.Quit();              //escape the application with...escape. will be used for menu later
        }


    }


    /// <summary>
    /// Trigger used for laps and 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint Trigger"))   //if the player is what touches the waypoint, using tag
        {
           other.gameObject.SetActive(false);       //disable the waypoing trigger so it doesn't trigger twice
            
            waypointsMet++;                        //add one to waypoint count


            if (waypointsMet == waypointCount)
            {
                lapsMet++;                        //increment laps, all waypoints hit
                
                lapsText.text = lapsMet.ToString() + "/" + lapCount.ToString();

                if (lapsMet != lapCount)
                {
                    waypointsMet = 0;
                }
                

                if (lapsMet == lapCount)
                {
                    
                    if (time.IsAlive == true)             //checks if time thread is still alive
                    {
                        time.Abort();                     //kill the time thread
                    }
                    SceneManager.LoadScene("Test");
                    //load menu here in the future
                }
            }

            
            
        }
    }

    

   


}
