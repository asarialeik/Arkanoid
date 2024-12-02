using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    public int brickType;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PointsCalc()
    {
        //int points = BrickManager.PointsForBrick(brickType);
        //ScoreManager.Instance.AddPoints(points);
    }

}
