using UnityEngine;

public class AnimController : ScriptableObject
{
    public string animName = "Walk";

    public void AnimCall(Animator animator)
    {
        animator.SetTrigger(animName);
    }
}
