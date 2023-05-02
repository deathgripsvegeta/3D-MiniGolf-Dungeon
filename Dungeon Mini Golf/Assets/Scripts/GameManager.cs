using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        if(other.gameObject.CompareTag("Player"))
        {
            if(this.gameObject.CompareTag("ball"))
            {
                Debug.Log("hit ball");
            }
        }
    }
}
