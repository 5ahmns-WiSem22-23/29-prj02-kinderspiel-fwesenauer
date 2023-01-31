using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalScript : MonoBehaviour
{
    public GameObject BackGroundWinLoose;
    public GameObject WinText;
    
    public int winCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            winCounter++;
            Destroy(collision.gameObject);

            if (winCounter == 2)
            {
                BackGroundWinLoose.SetActive(true);
                WinText.SetActive(true);
            }
        }
        // Start is called before the first frame update
        
    }
}
