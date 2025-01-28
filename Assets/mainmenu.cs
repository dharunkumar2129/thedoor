using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void mainmenu1()
    {
        SceneManager.LoadScene(0);
    }

    public void quit1()
    {
        Application.Quit();
    }
}
