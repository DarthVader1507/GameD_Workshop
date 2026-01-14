using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExitControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]private GameObject DeathPanel;
    private DeathScript deathScript;
    public void Start()
    {
        deathScript = FindObjectOfType<DeathScript>();
        DeathPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        DeathPanel.SetActive(false);
        Time.timeScale = 1f;
        deathScript.isDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
