using UnityEngine;
using System;
public class EnemySpawning : MonoBehaviour
{
    public GameObject BadGuy;

    public System.Random rnd = new System.Random();
    int max = 10;
    int min = 3;

    // Start is called before the first frame update
    void Start()
    {

    }
    int A(){
        if (rnd.Next(0, 2) == 1) { 
            return -1;
        }
        return 1;
    }
    void Spawn() {
        Instantiate(BadGuy, new Vector2(rnd.Next(min, max) * A(), rnd.Next(min, max) * A()), Quaternion.identity);
    }
    private float nextActionTime = 0.0f;
    public float inital = 2f;
    void Update () {
         if (inital < nextActionTime ) {
            Spawn();
            nextActionTime = 0f;
            inital -= 0.1f;
         }
         else {
            nextActionTime += Time.deltaTime;
         }
     }
}
