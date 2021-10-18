using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANTSPAWN : MonoBehaviour
{
    public GameObject ant;
    private GameObject antObject;

    private int PickRandomNumber(){
        int randomNum = Random.Range(0,2);
        return randomNum;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void createAnt(){
        int location = PickRandomNumber();

        if(location == 0){
            antObject = Instantiate(ant, new Vector3(9.3f, -1.4f, 7.1f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
        else{
            antObject = Instantiate(ant, new Vector3(9.3f, -1.4f, 6.7f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
    }
}