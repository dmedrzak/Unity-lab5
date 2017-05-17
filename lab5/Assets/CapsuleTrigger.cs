using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleTrigger : MonoBehaviour {
    public GameObject DoorGameObject;
    private Animator animator;

    void Awake()
    {
        animator = DoorGameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("isOpen", true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("isOpen", false);
        }
    }
}
