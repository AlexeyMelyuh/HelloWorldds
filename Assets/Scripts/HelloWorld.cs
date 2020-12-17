using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    
    float healthPlayer = 100f;
    float stamina = 1.5f;
    int road = 100;
    int playerW = 1;
    int playerRoad;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (healthPlayer < 1)
        {
            print("Lol You Die");
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Player health " + (healthPlayer = healthPlayer - stamina));
            print("Пройденная дистанция " + playerW++);
            print("Осталось пройти" + (playerRoad = road - 1));
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("Player health " + (healthPlayer = healthPlayer + 1));
        }

        if (Input.GetKey(KeyCode.W))
        {
            print("Player health " + (healthPlayer = healthPlayer - stamina * 2));
        }



        
    }
}
