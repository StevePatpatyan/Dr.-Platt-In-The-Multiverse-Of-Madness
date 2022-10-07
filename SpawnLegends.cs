using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLegends : MonoBehaviour
{
    public GameObject poole;
    public GameObject neat;
    public GameObject moses;
    public GameObject hall;
    public GameObject cheney;
    public GameObject sakonju;
    public GameObject workman;
    public GameObject briscoe;
    public GameObject[] platts;
    public Vector3 cannon;
    public Vector2 force; 
    // Start is called before the first frame update
    void Start()
    {
        cannon = new Vector3(-7, -0.93f, 0);
        force = new Vector2(500, 500);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            cannon = new Vector3(-7,-0.93f,0);
            force = new Vector2(500, 500);
        }
        else if (Input.GetKeyDown("right"))
        {
            cannon = new Vector3(7,0.93f,0);
            force = new Vector2(-500, 500);
        }
        if (Input.GetKeyDown("p"))
        {
            Instantiate(poole,cannon,new Quaternion(0,0,0,0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("n"))
        {
            Instantiate(neat,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("c"))
        {
            Instantiate(cheney,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("m"))
        {
            Instantiate(moses,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("h"))
        {
            Instantiate(hall,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("s"))
        {
            Instantiate(sakonju,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("w"))
        {
            Instantiate(workman,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
        }
        if (Input.GetKeyDown("b"))
        {
            Instantiate(briscoe,cannon, new Quaternion(0, 0, 0, 0)).GetComponent<Rigidbody2D>().AddForce(force);
            
        }
        if (Input.GetKeyDown("space"))
        {
            Instantiate(platts[Random.Range(0, 11)],new Vector3(0,0,0),new Quaternion(0,0,0,0));
        }

    }
}
