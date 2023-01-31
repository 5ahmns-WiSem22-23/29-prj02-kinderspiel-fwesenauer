using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class boatscript : MonoBehaviour
{
    public GameObject BackGroundWinLoose;
    public GameObject LooseText;
    

    public GameObject FishBlue;
    public GameObject FishPink;
    public GameObject FishYellow;
    public GameObject FishOrange;

    public GameObject FishBoatBlue;
    public GameObject FishBoatPink;
    public GameObject FishBoatYellow;
    public GameObject FishBoatOrange;


    public int failedCounter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == FishBlue)
        {
            Debug.Log("collided w blue");
            failedCounter++;
            FishBlue.SetActive(false);
            FishBoatBlue.SetActive(true);
        }
        if (collision.gameObject == FishPink)
        {
            Debug.Log("collided w pink");
            failedCounter++;
            FishPink.SetActive(false);
            FishBoatPink.SetActive(true);
        }
        if (collision.gameObject == FishYellow)
        {
            Debug.Log("collided w yellow");
            failedCounter++;
            FishYellow.SetActive(false);
            FishBoatYellow.SetActive(true);
        }
        if (collision.gameObject == FishOrange)
        {
            Debug.Log("collided w orange");
            failedCounter++;
            FishOrange.SetActive(false);
            FishBoatOrange.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (failedCounter == 2)
        {
            BackGroundWinLoose.SetActive(true);
            LooseText.SetActive(true);
        }
    }
}
