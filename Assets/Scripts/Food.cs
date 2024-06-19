using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    float speed = 10;
    public int foodDamage = 25;
    private float foodduration = 3f;


    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        foodduration -= Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (foodduration <= 0)
        {
            Destroy(gameObject);
        }
    }


}
