using UnityEngine;

public class DeathScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]private GameObject deathPanel;
    public bool isDead;
    public int coinscore;
    void Start()
    {
        isDead = false;
        coinscore = 0;
    }
    public void OnCollisionEnter2D(Collision2D collision){
        if ((collision.gameObject.CompareTag("Enemy")) && isDead == false){
            isDead = true;
            Time.timeScale = 0;
            deathPanel.SetActive(true);
        }
    }
}
