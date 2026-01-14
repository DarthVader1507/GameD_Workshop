using UnityEngine;

public class VictoryScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private DeathScript deathScript;
    [SerializeField] private GameObject victoryPanel;
    void Start()
    {
        deathScript = FindObjectOfType<DeathScript>();
        victoryPanel.SetActive(false);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && deathScript.isDead == false)
        {
            Debug.Log("Victory!");
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }
    }
}
