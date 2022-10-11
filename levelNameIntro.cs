using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelNameIntro : MonoBehaviour
{
    Animator animator;
    public string animationSlideOutName;

    // precise values so we can delete the gameObject right after
    public int slideInDuration;
    public int textOnScreenDuration;
    public int slideOutDuration;

    public void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    public void Start()
    {
        StartCoroutine(Animation());
    }

    public IEnumerator Animation()
    {
        yield return new WaitForSeconds(slideInDuration);
        yield return new WaitForSeconds(textOnScreenDuration);
        animator.Play(animationSlideOutName);
        yield return new WaitForSeconds(slideOutDuration);
        Destroy(gameObject);
    }
}
