using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float rotateMoveSpeed = 5f;
    public GameObject Club;
    public bool ClubIsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.P) && !ClubIsActive)
        {
            Club.SetActive(true);
            ClubIsActive = true;
        }
        else if(Input.GetKeyDown(KeyCode.P) && ClubIsActive)
        {
            Club.SetActive(false);
            ClubIsActive = false;
        }
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * zValue * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * xValue * rotateMoveSpeed * Time.deltaTime);
        
    }
}
