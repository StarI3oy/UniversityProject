using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTrailRendererHandler : MonoBehaviour
{
    //Components
    TopDownCarController topDownCarController;
    TrailRenderer trailRenderer;

    void Awake()
    {
        //Get the top down car controller
        topDownCarController = GetComponentInParent<TopDownCarController>();

        //Get the trail renderer component
        trailRenderer = GetComponent<TrailRenderer>();

        //Set the trail renderer to not emit in the start
        trailRenderer.emitting = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the car tires are screeching then we'll emitt a trail
        if (topDownCarController.IsTireScreeching(out float lateralVelocity, out bool isBraking))
            trailRenderer.emitting = true;
        else trailRenderer.emitting = false;
    }
}
