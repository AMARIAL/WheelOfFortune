using UnityEngine;

public class Drum : MonoBehaviour
{
    public static Drum ST {get; private set;}

    private Animator animator;

    private bool isSpin;
    
    
    private void Awake()
    {
        if (ST != null)
        {
            Destroy(gameObject);
            return;
        }
        ST = this;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        //animator.Play("Drum-Spin");
        animator.speed = 0f;
    }

    public void SpinButton ()
    {
        if (isSpin)
        {
            animator.speed = 0f;
        }
        else
        {
            animator.speed = 1f;
        }

        isSpin = !isSpin;

    } 
    
}
