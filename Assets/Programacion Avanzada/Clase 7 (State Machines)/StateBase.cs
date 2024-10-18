using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class StateBase<TController>
where TController : MonoBehaviour
{
    // Variables
    protected TController Controller { get; set; }

    // Methods
    public void Initialize(TController controller)
    {
        Controller = controller;
    }

    public virtual void Enter() { }
    public virtual void Logic() { }
    public virtual void FixedLogic() { }
    public virtual void Exit() { }
}
