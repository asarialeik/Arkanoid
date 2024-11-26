using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    float xAxisMovement;
    float playerSpeed = 7.5f;
    [SerializeField]
    float leftLimit = -7.375f;
    [SerializeField]
    float rightLimit = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xAxisMovement = Input.GetAxis("Horizontal");
        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + xAxisMovement * playerSpeed * Time.deltaTime, leftLimit, rightLimit);
        transform.position = playerPosition;

    }
}
