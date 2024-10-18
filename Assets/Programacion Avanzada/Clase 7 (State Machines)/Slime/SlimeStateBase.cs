using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeStateBase : StateBase<SlimeController>
{
    public bool DetectPlayer()
    {
        // if (Physics.OverlapSphere(Controller.transform.position))
        Debug.Log("Buscando al jugador");

        if (Random.Range(0, 100) == 0)
        {
            return true;
        }

        return false;
    }
}