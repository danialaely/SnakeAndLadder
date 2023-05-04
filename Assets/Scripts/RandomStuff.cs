using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class RandomStuff : MonoBehaviour
{
    public TextMeshPro largeText;
    public Transform gameobjectTransform;
    //public float moveDistance = 1f;
    public float moveTime = 0.05f;
    public static bool isMoving = false;
    //private Vector3 targetPosition;

    public List<GameObject> waypoints;
    public float speed = 2;
    int index = 0;

    public static int position=0;
    

    

    

    public void BtnAction()
    {
        if (!isMoving)
        {
            PickRandomNumber(6);
        }
    }

    private void PickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1, maxInt + 1);
        largeText.text = randomNum.ToString();

        position += randomNum;
       // Debug.Log(position);

       

    }

    public void Update()
    {

        Vector3 startingPosition = gameobjectTransform.position;
        Vector3 destination = waypoints[index].transform.position;
        gameobjectTransform.position = Vector3.MoveTowards(startingPosition, destination, speed * Time.deltaTime);
       
        isMoving = true;

        float distance = Vector3.Distance(startingPosition,destination);

        if (distance <= moveTime) 
        {
            index = position;
            isMoving = false;
        }

        


        //Debug.Log(isMoving);
    }


}
