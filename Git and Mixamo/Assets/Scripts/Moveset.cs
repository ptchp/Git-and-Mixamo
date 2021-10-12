using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveset : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isOne", true);
            animator.SetBool("isTwo", false);
            Debug.Log("A");
        }


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isOne", false);
            animator.SetBool("isTwo", true);
            Debug.Log("S");
        }

    }
}