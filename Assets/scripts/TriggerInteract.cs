using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteract : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Interact");

        }
         if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("Reverse");
}
    }
}
