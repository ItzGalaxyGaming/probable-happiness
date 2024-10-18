using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SlimeStateFactory : StateFactory<SlimeController>
{
    public SlimeState_Idle idle;
    public SlimeState_Patrol patrol;
    public SlimeState_FollowPlayer followPlayer;
    public SlimeState_Death death;

    public override void Initialize(SlimeController controller)
    {
        idle.Initialize(controller);
        patrol.Initialize(controller);
        followPlayer.Initialize(controller);
        death.Initialize(controller);
    }
}
