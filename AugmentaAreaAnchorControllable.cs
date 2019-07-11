using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugmentaAreaAnchorControllable : Controllable {

    [Header("Augmenta Manager Settings")]

    [OSCProperty]
    [Range(0.0f, 50.0f)]
    public float distanceToArea;

    [OSCProperty]
    public float PersonTimeOut;
	
    [OSCProperty]
    public float PositionFollowTightness;

    [OSCProperty]
    public bool usePhysic;

    [OSCProperty]
    [Range(1, 20)]
    public int VelocityAverageValueCount;
	
}
