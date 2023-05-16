using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] public float _rotateMoveSpeed = 1f;
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
        float zValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float xValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        Vector3 movementDirection = new Vector3(xValue, 0f, zValue);
        movementDirection.Normalize();
        transform.Translate(xValue, 0f, zValue);
    }
}
