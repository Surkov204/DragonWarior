
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScrene;
    [SerializeField] private GameObject PauseMenu;
    private PlayerRespawn playerRespawn;
    [SerializeField] private AudioClip playsound;
    private float currentChange = 0f;
    private void Awake()
    {
        playerRespawn = FindObjectOfType<PlayerRespawn>();
        gameOverScrene.SetActive(false);
        PauseMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.activeInHierarchy)
                activePauseMenu(false);
            else
                activePauseMenu(true);
        }
    }
    
    public void GameOver()
    {
        gameOverScrene.SetActive(true);
    }
    public void Restart()
    {

        gameOverScrene.SetActive(false);
        playerRespawn.respawn();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Quit()
    {
        SceneManager.LoadSceneAsync("Quit");
    }

    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void activePauseMenu(bool status)
    {
        PauseMenu.SetActive(status);
        if (status == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    public void soundMenu()
    {
        //currentChange =+ 0.2f;
        Audio.instance.changeSound(0.1f);
        Audio.instance.PlaySound(playsound);
    }
    public void MusicMenu()
    {
     
        Audio.instance.changeMusic(0.1f);
        Audio.instance.PlaySound(playsound);
    }
   
}
