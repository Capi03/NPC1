using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   
    // level npc
    public int level = 1;

    // health npc
    public int health = 5;

    //speed npc
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //health = health + level
        health += level;
        print("vida del jugador;" + health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
