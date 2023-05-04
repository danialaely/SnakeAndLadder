using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationS : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isFallDown", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomStuff.isMoving == true)
        {
            animator.SetBool("isMove", true);
        }

       else if (RandomStuff.position==28) 
        {
            animator.SetBool("isFall", true);
            StartCoroutine(SetBoolFalseAfterDelay(2f, "isFall"));
            StartCoroutine(SetBoolTrueAfterDelay(3.5f, "isFallDown"));
        }

        else
        {
            animator.SetBool("isMove", false);
        }
    }
    IEnumerator SetBoolTrueAfterDelay(float delay, string boolName)
    {
        yield return new WaitForSeconds(delay);
        animator.SetBool(boolName, true);
    }
    IEnumerator SetBoolFalseAfterDelay(float delay, string boolName)
    {
        yield return new WaitForSeconds(delay);
        animator.SetBool(boolName, false);
    }

}
