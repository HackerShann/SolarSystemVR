using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarManager : MonoBehaviour
{
    public GameObject MercuryDisp;
    public GameObject VenusDisp;
    public GameObject EarthDisp;
    public GameObject MoonDisp;
    public GameObject MarsDisp;
    public GameObject JupiterDisp;
    public GameObject SaturnDisp;
    public GameObject UranusDisp;
    public GameObject NeptuneDisp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) ||
            OVRInput.Get(OVRInput.RawButton.RIndexTrigger) ||
            Input.GetKey(KeyCode.B)) //the b key is so we can test in unity before building
        {
            print("show");
            MercuryDisp.SetActive(true);
            VenusDisp.SetActive(true);
            EarthDisp.SetActive(true);
            MoonDisp.SetActive(true); 
            MarsDisp.SetActive(true);
            JupiterDisp.SetActive(true);
            SaturnDisp.SetActive(true);
            UranusDisp.SetActive(true);
            NeptuneDisp.SetActive(true);
        }
        else
        {
            MercuryDisp.SetActive(false);
            VenusDisp.SetActive(false);
            EarthDisp.SetActive(false);
            MoonDisp.SetActive(false);
            MarsDisp.SetActive(false);
            JupiterDisp.SetActive(false);
            SaturnDisp.SetActive(false);
            UranusDisp.SetActive(false);
            NeptuneDisp.SetActive(false);
        }
    }
}
