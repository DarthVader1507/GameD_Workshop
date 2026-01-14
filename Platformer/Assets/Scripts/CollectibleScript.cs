using UnityEngine;
using UnityEngine.UI;
public class CollectibleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private DeathScript deathScript;
    [SerializeField]private Text scoreText;
    [SerializeField]private GameObject collectible;
    void Start()
    {
        deathScript = FindObjectOfType<DeathScript>();
        scoreText.text = deathScript.coinscore.ToString();//Sets score text to initial score
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))//Checks if player collides with collectible
        {
            Debug.Log("Collectible picked up!");
            deathScript.coinscore += 1;
            Debug.Log("Score: " + deathScript.coinscore);
            scoreText.text = deathScript.coinscore.ToString();
            collectible.SetActive(false);//Disables collectible object
        }
    }
}
