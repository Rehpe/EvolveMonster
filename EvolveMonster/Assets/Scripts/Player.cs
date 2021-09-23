using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    [HideInInspector]
    public float speed = 0.01f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        if (transform.position.x > 2.8f)
        {
            speed *= -1;
        }

        if (transform.position.x < -2.8f)
        {
            speed *= -1;
        }

        if (Input.GetMouseButtonDown(0))
        {
            speed *= -1;
        }

        transform.position += new Vector3(speed, 0, 0);

    }

    void OnCollisionEnter2D(Collision2D coll)

    {
        int score = GameObject.Find("ElementSpawner").GetComponent<ElementSpawner>().score;
        int firePoint = GameObject.Find("ElementSpawner").GetComponent<ElementSpawner>().firePoint;
        int waterPoint = GameObject.Find("ElementSpawner").GetComponent<ElementSpawner>().waterPoint;
        int elecPoint = GameObject.Find("ElementSpawner").GetComponent<ElementSpawner>().elecPoint;

        if (coll.gameObject.tag == "elements")
        {
            gameManager.I.addScore(score); //Á¡¼ö È¹µæ

            bool isfire = coll.gameObject.name.Contains("fire");
            bool iswater = coll.gameObject.name.Contains("water");
            bool iselec = coll.gameObject.name.Contains("elec");

            if (isfire)
                gameManager.I.addFirePoint(firePoint);
            else if (iswater)
                gameManager.I.addWaterPoint(waterPoint);
            else if (iselec)
                gameManager.I.addElecPoint(elecPoint);


            Destroy(coll.gameObject);
        }
    }
}
