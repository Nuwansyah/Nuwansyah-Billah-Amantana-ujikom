using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject object1;
    [SerializeField] GameObject object2;
    [SerializeField] GameObject object3;
    [SerializeField] GameObject object4;
    [SerializeField] GameManager manager;
    float timer;
    float time;


    private void Awake()
    {
        
        time = Random.Range(5f, 12f);
    }
    // Update is called once per frame
    void Update()
    {
        timer = Random.Range(5f, 12f);
        time -= Time.deltaTime;
        if(time <= 0)
        {
            int randomSpawn = Random.Range(1, 4);
            if (randomSpawn == 1)
            {
                Instantiate(object1, transform.position, transform.rotation);
            }
            if (randomSpawn == 2)
            {
                Instantiate(object2, transform.position, transform.rotation);
            }
            if (randomSpawn == 3)
            {
                Instantiate(object3, transform.position, transform.rotation);
            }
            if (randomSpawn == 4)
            {
                Instantiate(object4, transform.position, transform.rotation);
            }
            time = timer;
        }
    }
}
