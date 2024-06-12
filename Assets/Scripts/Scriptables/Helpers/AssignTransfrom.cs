using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignTransform : MonoBehaviour
{
    public TransformVariable transformVariable;

    private void OnEnable()
    {
        //Debug.Log(this.transform);
        transformVariable.value = this.transform;
        Destroy(this);
    }

}
