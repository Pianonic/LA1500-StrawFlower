using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    int yCords = 1;
    public GameManagerScript gameManager;
    private bool isDead;
    // Start is called before the first frame update.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            if(transform.position.x != 11f)
            {
                transform.position = new Vector3((transform.position.x - 4), yCords, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (transform.position.x != 19f)
            {
                transform.position = new Vector3((transform.position.x + 4), yCords, 0);
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ObsticalTag" && !isDead)
        {
            isDead = true;
            gameManager.gameOver(); 
        }    
    }


}
