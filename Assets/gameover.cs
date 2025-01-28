using UnityEngine;

public class gameover : MonoBehaviour
{
    public float a;
    public GameObject b;
    public GameObject c;
    public AudioClip clip1;
    public AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            a = a + 1;
            if(a==4) 
            {
                b.SetActive(true);
                c.SetActive(false);
                source.PlayOneShot(clip1);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;

            }
        }
    }
   
}
