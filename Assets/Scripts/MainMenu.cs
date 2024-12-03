using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject startMenu;

    void Start()
    {
        startMenu.SetActive(true);
    }

    void Update()
    {
        
    }
}
