using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OnClickT()
    {
        SceneManager.LoadScene("Title");
    }
    public void OnClickM()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnClickE()
    {
        Application.Quit();
    }
}
