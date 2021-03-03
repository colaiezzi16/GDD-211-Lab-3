using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIscript : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 2;
    int MaxDist = 3;
    int MinDist = 1;
    int armor = 2;




   /* void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }

        if (armor == 0){
            Destroy(gameObject);        
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        armor--;
    }

    private void Chase()
    {
        transform.LookAt(Player);

        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
        if (armor == 0)
        {
            Destroy(gameObject);
        }

    }
}

