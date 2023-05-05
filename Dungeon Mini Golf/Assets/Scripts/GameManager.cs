using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject Ball; 
    [SerializeField] private Rigidbody _ballRB;
    [SerializeField] public GameObject Player;
    [SerializeField] public Slider hitForceSlider;
    [SerializeField] public float hitForce;
    // Start is called before the first frame update
    void Start()
    {
        _ballRB.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(this.gameObject.tag == "ball")
        {
            if(other.gameObject.tag == "Player")
            {
                Debug.Log("hit ball");
            }
        }
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(this.gameObject.CompareTag("Player"))
        {
            if(other.gameObject.CompareTag("ball"))
            {
                Rigidbody _ballRB = other.gameObject.GetComponent<Rigidbody>();
                Vector2 awayFromPlayer = (other.gameObject.transform.position - transform.position); 
                _ballRB.AddForce(awayFromPlayer * hitForce, ForceMode.Impulse);
                hitForceSlider.gameObject.SetActive(false);
            }
        }
    }
}

