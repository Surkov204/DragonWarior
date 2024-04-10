
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
 
    private Transform currentCheckpoint;
    private health playerHealth;
    private UiManager uiManager;

    private void Awake()
    {
        playerHealth = GetComponent<health>();
        uiManager = FindObjectOfType<UiManager>();
    }
    public void checkRespawn()
    {
        gameObject.SetActive(false);
        uiManager.GameOver();
    }
    public void respawn()
    {
        gameObject.SetActive(true);
        playerHealth.Respawn(); //Restore player health and reset animation
        transform.position = currentCheckpoint.position; //Move player to checkpoint location

        //Move the camera to the checkpoint's room
        Camera.main.GetComponent<camera>().MoveToNewRoom(currentCheckpoint.parent);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "checkpoint")
        {
            currentCheckpoint = collision.transform;
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");

        }
    }
}