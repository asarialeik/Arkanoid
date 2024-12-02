using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    [SerializeField]
    public float[] bricksScores;
    [SerializeField]
    public float[] bricksTypes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointsForBrick(int brickType)
    {
        //return brickpoints[brickType];
    }
}
