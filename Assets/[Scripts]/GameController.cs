using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public GameObject onScreenControls;
    // Start is called before the first frame update
    void Awake()
    {
        //onScreenControls = GameObject.Find("OnScreenControls");
        //onScreenControls.SetActive(Application.isMobilePlatform);
    }

    // Update is called once per frame
    void Update()
    {
        //FindObjectOfType<SoundManager>().PlayMusic();

        if (Input.GetKeyDown(KeyCode.K))
        {
            FindObjectOfType<HealthBarController>().TakeDamage(20);
        }
    }
}
