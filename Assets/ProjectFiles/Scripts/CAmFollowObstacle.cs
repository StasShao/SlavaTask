using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAmFollowObstacle : CameraSmoothLookFollowWithPlaneCheck
{
    [SerializeField] private Transform Camera;
    [SerializeField] private Transform Target;
    [SerializeField] private Transform Pivot;
    [SerializeField] private LayerMask PlaneLayer;
    [SerializeField] private float SpeedCoef;
    [SerializeField] private Vector3 Offset;

    private void LateUpdate()
    {
        Search(Camera,Target,Pivot,PlaneLayer,SpeedCoef,Offset);
    }
}
