using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Start()
    {
        
    }
    
   
  
    
   
    public FixedTouchField touchfield;
    public Transform player;
    public float sensitivity = 100f;
    float Mousex;
    float Mousey;
    float xrotation;
    float yrotation;

    private void Update()
    {
        MyInput(); }

    void MyInput()
    {
        float Mousex = touchfield.TouchDist.x * sensitivity * Time.deltaTime;
        float Mousey = touchfield.TouchDist.y * sensitivity * Time.deltaTime;
        xrotation -= Mousey;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        
        transform.localRotation=Quaternion.Euler(xrotation,0, 0);
       
        player.Rotate(Vector3.up*Mousex);
        player.Rotate(Vector3.up*Mousey);
    

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
            