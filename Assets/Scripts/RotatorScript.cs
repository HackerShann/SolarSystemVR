using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public GameObject WhoToOrbit;
    public float OrbitSpeed;
    public float SelfRotateSpeed;
    public Vector3 WhoToOrbitPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WhoToOrbitPosition = WhoToOrbit.transform.position;

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) ||
            OVRInput.Get(OVRInput.RawButton.RIndexTrigger) ||
            Input.GetKey(KeyCode.B))
        {
            transform.RotateAround(WhoToOrbitPosition, Vector3.up, 0);
            transform.Rotate(Vector3.up * SelfRotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(WhoToOrbitPosition, Vector3.up, OrbitSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * SelfRotateSpeed * Time.deltaTime);
        }

        /* Time.deltaTime is the completion time in seconds since the last frame
         * so, assuming 72 frames per sec, 1 divided by 72 = 0.0138888889 is out basic time unit. One Frame.
         * That is also in the "Time Project Setting".
         * So for example, if we rotate something at 72*Time.deltaTime, it will complete 1 rotation in 1 second
         * So for example, if we rotate something at 7.2*Time.deltaTime, it will complete 1 rotation in 10 seconds */
        
    }
}