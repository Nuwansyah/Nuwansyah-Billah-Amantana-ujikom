using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;
    public GameObject foodie;
    Vector3 locationSpawn;
    [SerializeField] float maxSpeed = 1;
    [SerializeField] float animationCooldownMax = 0.3f;
    [SerializeField] float animationCooldown = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        characterController.Move(move * Time.deltaTime * maxSpeed);

        //animation
        animator.SetFloat("MoveDir", Input.GetAxis("Horizontal"));

        locationSpawn = new Vector3(0, 1, 0.5f);
        //throw mechanic
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(foodie, transform.position + locationSpawn, transform.rotation);
            animator.SetBool("isFiring", true);
            animationCooldown = 0.2f;
        }
        animationCooldown -= Time.deltaTime;
        if (animationCooldown <= 0)
        {
            animationCooldown = 0;
            animator.SetBool("isFiring", false);
        }
         

    }
}
