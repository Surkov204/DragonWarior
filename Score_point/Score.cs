
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour, IDdataPersistence
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private AudioClip soundScore;
    int scoreValue = 0;

    private void Start()
    {
        scoreValue = 0;
        scoreText.text = "Score: " + scoreValue;
       
    }

    public void LoadData(GameData data)
    {
        this.scoreValue = data.scoreValue;
    }
    public void SaveData(ref GameData data)
    {
        data.scoreValue = this.scoreValue;
    }
   
  
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="score")
        {
            Audio.instance.PlaySound(soundScore);
            Destroy(collision.gameObject);
            scoreValue += 1;
            scoreText.text = "Score: " + scoreValue;
        }
   
    }
}

