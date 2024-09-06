using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator tidak ditemukan pada GameObject ini.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TriggerAnimation();
        }
    }

    void TriggerAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("Aura");
        }
    }
}