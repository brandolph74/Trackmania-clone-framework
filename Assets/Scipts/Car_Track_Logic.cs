using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Track_Logic : MonoBehaviour
{

    public LevelManager TrackManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //find gameobject by name
        TrackManager = GameObject.Find("Track Manager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Checkpoint")
        {
            TrackManager.enterWaypoint();
        }
    }

}
