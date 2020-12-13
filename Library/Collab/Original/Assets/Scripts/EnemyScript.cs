using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    GameObject Player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Vector2 Target = new Vector2(Player.transform.position.x, Player.transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, Target, step);
    }
}
