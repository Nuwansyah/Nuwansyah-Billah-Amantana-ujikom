using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimalControl : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject gamemanager;
    [SerializeField] float speed = 1.2f;
    public float health = 100;
    public float maxHealth = 100;
    public int damagewhenHIT = 25;
    public Food food;
    void Awake()
    {
        gamemanager = GameObject.Find("GameManager");
        gameManager = gamemanager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (health <= 0)
        {
            gameManager.score += 1;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        health -= damagewhenHIT;
    }

    

}
