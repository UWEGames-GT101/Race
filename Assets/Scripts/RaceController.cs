using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceController : MonoBehaviour
{
    public GameObject[] checkPoint;

    public bool raceOn = false;
    public int checkPointsPassed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(raceOn)
        {
            //Debug.Log("Race Started");
        }
    }

    void StartRace()
    {
       
    }

    public void RaceOn()
    {
        raceOn = true;
    }
}
