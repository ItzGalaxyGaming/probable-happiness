using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateFactory<TController>
where TController : MonoBehaviour
{
    // Methods
    public abstract void Initialize(TController controller);
}