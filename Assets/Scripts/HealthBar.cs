using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] AnimalControl animalcontrol;
    [SerializeField] Image image;
    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Awake()
    {
        animalcontrol  = GetComponent<AnimalControl>();
        canvas = GetComponentInChildren<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillbar = animalcontrol.health / animalcontrol.maxHealth;
        image.fillAmount = fillbar;
        Debug.Log(fillbar);

    }
}
