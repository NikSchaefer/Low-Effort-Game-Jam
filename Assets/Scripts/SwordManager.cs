using UnityEngine;
using TMPro;

public class SwordManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
