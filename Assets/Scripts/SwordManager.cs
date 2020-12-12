using UnityEngine;
using TMPro;

public class SwordManager : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        SpinSword();
    }

    void SpinSword()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }

}
