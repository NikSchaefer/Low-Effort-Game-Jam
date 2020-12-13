using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public GameObject Player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Vector2 Target = new Vector2(Player.transform.position.x, Player.transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, Target, step);
    }
}
