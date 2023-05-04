using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject Ball; 
    [SerializeField] public GameObject Player;
    [SerializeField] public Slider hitForceSlider;
    [SerializeField] public float hitForce;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
