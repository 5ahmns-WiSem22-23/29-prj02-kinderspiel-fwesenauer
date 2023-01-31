using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubescript : MonoBehaviour
{
    public GameObject cube;

    public GameObject yellow;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject boot;

    public int moveRight = 1;

    public int changePostion = 5;

    public Material[] materials = new Material[7];
    private Renderer rend;

    public Text PlayerStatus;

    public boatscript BoatScript;

    void Start()
    {
        rend = GetComponent<Renderer>();

       // rend.material = materials[0];
    }

    void OnMouseDown()
    {
        int randomIndex = Random.Range(1, materials.Length);
        rend.material = materials[randomIndex];
        StartCoroutine(ComputerMove());

        if (randomIndex == 1 )
        {
            Debug.Log("jetzt blau");
            blue.transform.position += new Vector3(moveRight, 0, 0);
        }
        

        if (randomIndex == 2)
        {
            Debug.Log("jetzt grün");
            boot.transform.position += new Vector3(moveRight, 0, 0);
        }

        if (randomIndex == 3 )
        {
            Debug.Log("jetzt orange");
            orange.transform.position += new Vector3(moveRight, 0, 0);
        }
        

        if (randomIndex == 4 )
        {
            Debug.Log("jetzt pink");
            pink.transform.position += new Vector3(moveRight, 0, 0);
        }
       

        if (randomIndex == 5)
        {
            Debug.Log("jetzt rot");
            boot.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 6 )
        {
            Debug.Log("jetzt gelb");
            yellow.transform.position += new Vector3(moveRight, 0, 0);
        }
        
    }

    private IEnumerator ComputerMove()
    {
        PlayerStatus.text = "Computers Turn";
        yield return new WaitForSeconds(2);
        int randomIndex = Random.Range(1, materials.Length);
        rend.material = materials[randomIndex];
        if (randomIndex == 1)
        {
            Debug.Log("jetzt blau");
            blue.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 2)
        {
            Debug.Log("jetzt grün");
            boot.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 3)
        {
            Debug.Log("jetzt orange");
            orange.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 4)
        {
            Debug.Log("jetzt pink");
            pink.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 5)
        {
            Debug.Log("jetzt rot");
            boot.transform.position += new Vector3(moveRight, 0, 0);
        }
        if (randomIndex == 6)
        {
            Debug.Log("jetzt gelb");
            yellow.transform.position += new Vector3(moveRight, 0, 0);
        }
        PlayerStatus.text = "Your Turn";
    }
    private void Update()
    {
       
    }


}
