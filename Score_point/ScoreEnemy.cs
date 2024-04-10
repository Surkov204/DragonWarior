
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreEnemy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public GameObject enemyObject;
    private float scoreValue = 0;

    private void Start()
    {
        scoreValue = 0;
        scoreText.text = "Score: " + scoreValue;
        
    }

    public void Deactivate()
    {
        scoreValue += 1;
        scoreText.text = "Score: " + scoreValue;
    }
}
