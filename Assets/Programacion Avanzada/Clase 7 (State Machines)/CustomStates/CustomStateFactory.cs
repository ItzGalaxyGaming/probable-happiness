using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomStateFactory : StateFactory<CustomController>
{
    //idle
    public CustomState_Idle idle;

    public override void Initialize(CustomController controller)
    {
        
    }
}
