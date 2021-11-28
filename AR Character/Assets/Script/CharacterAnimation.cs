using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator anim;
    string walk_parameters = "walk";
    string punch_parameters = "punch";
    string idle_parameters = "idle";
    string dancing_parameters = "dancing";
    string scream_parameters = "scream";

    bool isWalk, isPunch;

    public float timePunch, timeSteps;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   public void WalkingAnimation()
    {
        anim.SetTrigger(walk_parameters);
        AudioManager.singleton.stopSound();
        isWalk = true;
        isPunch = false;
        StartCoroutine(PlayStepsSound());

    }

    public void PunchAnimation()
    {
        anim.SetTrigger(punch_parameters);
        AudioManager.singleton.stopSound();
        isWalk = false;
        isPunch = true;
        StartCoroutine(PlayPunchSound());
    }

    public void IdleAnimation()
    {
        anim.SetTrigger(idle_parameters);
        AudioManager.singleton.stopSound();
        isWalk = false;
        isPunch = false;
    }

    public void DancingAnimation()
    {
        anim.SetTrigger(dancing_parameters);
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(0);
        isWalk = false;
        isPunch = false;
    }

    public void ScreamAnimation()
    {
        anim.SetTrigger(scream_parameters);
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(1);
        isWalk = false;
        isPunch = false;
    }

    IEnumerator PlayPunchSound()
    {
        yield return new WaitForSeconds(timePunch);
        
        if (isPunch)
        {
            AudioManager.singleton.PlaySound(2);
            StartCoroutine(PlayPunchSound());
        } 
        else if (!isPunch)
        {
            StopCoroutine("PlayPunchSound");
        }

    }

    IEnumerator PlayStepsSound()
    {
        yield return new WaitForSeconds(timeSteps);
        
        if (isWalk)
        {
            AudioManager.singleton.PlaySound(3);
            StartCoroutine(PlayStepsSound());
        }
        else if (!isWalk)
        {
            StopCoroutine("PlayStepsSound");
        }

        
    }
}
