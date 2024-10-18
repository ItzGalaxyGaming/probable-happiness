using UnityEngine;

[System.Serializable]
public class SlimeState_Death : SlimeStateBase
{
    public float time;
    public AnimationCurve curve;

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Me mori");
    }
}