using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSpawner : MonoBehaviour

{
    [SerializeField]
    private GameObject[] elements;

    public int score;
    public int firePoint;
    public int waterPoint;
    public int elecPoint;


    // Start is called before the first frame update

    void Start()
    {
   
        InvokeRepeating("ElementSpawn", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ElementSpawn()
    {
        int randomType = Random.Range(0, elements.Length);
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(6.0f, 7.0f);

        Vector3 position = new Vector3(x, y, 0);

        switch (randomType)
        {
            case 0:
                firePoint = 1;
                score = 1;
                break;
            case 1:
                waterPoint = 1;
                score = 1;
                break;
            case 2:
                elecPoint = 1;
                score = 1;
                break;
        }

        Instantiate(elements[randomType], position, Quaternion.identity);
    }

}