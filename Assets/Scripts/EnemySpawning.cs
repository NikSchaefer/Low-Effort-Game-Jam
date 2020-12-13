using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;

    public System.Random rnd = new System.Random();
    int max = 10;
    int min = 3;

    private float nextActionTime = 0.0f;
    public float inital = 2f;

    int A()
    {
        if (rnd.Next(0, 2) == 1)
        { 
            return -1;
        }

        return 1;
    }

    void Spawn()
    {
        Instantiate(Enemy1, new Vector2(rnd.Next(min, max) * A(), rnd.Next(min, max) * A()), Quaternion.identity);
        Instantiate(Enemy2, new Vector2(rnd.Next(min, max) * A(), rnd.Next(min, max) * A()), Quaternion.identity);
    }

    void Update ()
    {
         if (inital < nextActionTime )
         {
            Spawn();
            nextActionTime = 0f;
            if (inital > 0.2f) 
            {
                inital -= 0.1f;
            }
         }
         else 
         {
            nextActionTime += Time.deltaTime;
         }
     }
}
