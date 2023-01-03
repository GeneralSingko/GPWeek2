using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var jobless = new Jobless();
        var tank = new Tank();
        var support = new Support();
        var dps = new DPS();
        Debug.Log(message: jobless.GetProperties());
        Debug.Log(message: tank.GetProperties());
        Debug.Log(message: support.GetProperties());
        Debug.Log(message: dps.GetProperties());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
