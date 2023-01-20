using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int checkPointNumber;
    public GameObject raceController;
    public Material material;
    public Material material2;

    private GameObject gb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        if (checkPointNumber == raceController.GetComponent<RaceController>().checkPointsPassed)
        {
            Debug.Log(checkPointNumber);
            raceController.GetComponent<RaceController>().checkPointsPassed++;
        }
        
    }
}
