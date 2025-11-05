using UnityEngine;

public class RoboScript : MonoBehaviour
{
    Animator anim;

    // Initializes the animator component
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("Speed", 0f);
        anim.SetFloat("Direction", 0f);
    }

    // Makes the robot walk left/right with A/D or arrow keys
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A/D or ←/→
        float v = Input.GetAxis("Vertical");   // W/S or ↑/↓

        anim.SetFloat("Speed", h);
        anim.SetFloat("Direction", v);

        if (h < -0.1f) transform.LookAt(transform.position + Vector3.back);
        if (h >  0.1f) transform.LookAt(transform.position + Vector3.forward);
    }
}
