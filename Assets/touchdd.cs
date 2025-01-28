using UnityEngine;

public class touchdd : MonoBehaviour
{

    public FixedTouchField touchfield;
    public Transform player;
    public float sensitivity = 1f;
    float Mousex;
    float Mousey;
    float xrotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        myinput();
    }
    void myinput() {
        Mousex = touchfield.TouchDist.x*sensitivity*Time.deltaTime;
        Mousey =touchfield.TouchDist.y*sensitivity*Time.deltaTime;
        xrotation -= Mousey;
        xrotation = Mathf.Clamp(xrotation, -90, 90);
        transform.localRotation=Quaternion.Euler(xrotation, 0, 0);
        player.Rotate(Vector3.up * Mousex);

    }
}
