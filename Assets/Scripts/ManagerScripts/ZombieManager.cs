using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieManager : Singleton<ZombieManager>
{
    public int zombieNumber;
    public bool isGameActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        zombieNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive && zombieNumber == 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
