using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour, IAnimationBase
{
    [SerializeField]
    Animator animator;

    bool isFacingLeft;

    public void Move(Vector2 direction) 
    {
        animator.SetBool("Move", direction != Vector2.zero);
        if (Mathf.Approximately(direction.x, 0f))
            return;
        else
        {
            if(direction.x > 0f && isFacingLeft)
            {
                Flip();
            }
            else if(direction.x < 0f && !isFacingLeft)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        transform.rotation = isFacingLeft ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 180, 0);
        isFacingLeft = !isFacingLeft;
    }
}
