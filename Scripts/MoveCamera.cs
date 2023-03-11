using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;
    public Transform CamCal;
    public Transform thisCam;

    private void Start()
    {
        thisCam.transform.rotation = CamCal.transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
