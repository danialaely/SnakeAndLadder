using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutantmove : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomStuff.position == 28)
        {
            animator.SetBool("isFight", true);
        }
        else 
        {
            animator.SetBool("isFight", false);
        }
    }
}
